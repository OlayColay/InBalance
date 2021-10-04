using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using YounGenTech.HealthScript;
using DG.Tweening;
using static Constants;

public class Player : Actor
{
    private Health healthScript;
    public Animator animator;
    public Controls.BattleActions battleActions;
    public Controls.DefendActions defendActions;
    [SerializeField] private GameObject playerActionsUI;

    public Transform playerBase;

    /// <summary> The type that the button a player pushes is for </summary>
    private Type attemptedType = Type.Physical;
    private bool attemptAction = false;
    
    public Actor selectedEnemy;
    private int selectedEnemyNum = 0;
    private int attackCount = 0;

    public GameObject timeIndic;

    public bool invulnerable = false;

    /// <summary> The enemy that the player will attack </summary>
    public int SelectedEnemyNum {
        get
        {
            return selectedEnemyNum;
        }
        set
        {
            if (enemies.Length == 0)
            {
                return;
            }
            switch(value)
            {
                case 0:
                    selectedEnemy = enemies[0];
                    selectedEnemyNum = 0;
                    break;
                case 1:
                    selectedEnemy = enemies.Length < 2 ? enemies[0] : enemies[1];
                    selectedEnemyNum = enemies.Length < 2 ? 0 : 1;
                    break;
                case 2:
                    selectedEnemy = enemies.Length < 3 ? (enemies.Length < 2 ? enemies[0] : enemies[1]) : enemies[2];
                    selectedEnemyNum = enemies.Length < 3 ? (enemies.Length < 2 ? 0 : 1) : 2;
                    break;
                default:
                    Debug.LogError("SelectedEnemyNum is being set to in invalid number: " + value);
                    return;
            }
            if (battleActions.enabled) transform.DOMove(selectedEnemy.transform.GetChild(0).position, 0.5f);
        }
    }

    /// <summary> Element meters of the player </summary>
    public int[] elementMeters = {0, 0, 0, 0, 0};

    private int[] elementExperience = {0, 0, 0, 0, 0};
    /// <summary> Array of experience for player's elements </summary>
    public int[] EXP {
        get
        {
            return elementExperience;
        }
        set
        {
            elementExperience = value;
        }
    }

    private int[] nextLevel = {100, 100, 100, 100, 100};
    /// <summary> Array that experience has to reach to level up </summary>
    public int[] MaxEXP {
        get
        {
            return nextLevel;
        }
        set
        {
            nextLevel = value;
        }
    }

    public override int HP {
        set
        {
            value = Mathf.Min(value, MaxHP);
            healthScript.Value = value;
            base.HP = value;
        }
    }

    public override int MaxHP {
        set
        {
            healthScript.MaxValue = value;
            base.MaxHP = value;
        }
    }

    private void Awake()
    {
        healthScript = GetComponent<Health>();

        battleActions = new Controls().Battle;
        defendActions = new Controls().Defend;

        battleActions.Physical.performed += ctx => Attack(Type.Physical);
        battleActions.Air.performed += ctx => Attack(Type.Air);
        battleActions.Water.performed += ctx => Attack(Type.Water);
        battleActions.Earth.performed += ctx => Attack(Type.Earth);
        battleActions.Fire.performed += ctx => Attack(Type.Fire);
        battleActions.Lightning.performed += ctx => Attack(Type.Electric);

        battleActions.DirectionalInput.performed += ctx => SelectedEnemyNum = ctx.ReadValue<float>() < 0 ? 2 : 0;
        battleActions.DirectionalInput.canceled += ctx => SelectedEnemyNum = 1;

        defendActions.Block.performed += ctx => attemptAction = true;

        timeIndic = GameObject.Find("TimingIndicator");

    }

    private void Start()
    {
        battleManager = GameObject.FindObjectOfType<BattleManager>();
        SelectedEnemyNum = 1;
    }

    public void AttackSelected()
    {
        Debug.Log("Player attacks!");
        battleActions.Enable();
        playerActionsUI.SetActive(false);
        transform.DOMove(selectedEnemy.transform.GetChild(0).position, 0.5f);
        StartCoroutine(AttackTimingCoroutine());
    }

    public void RestSelected()
    {
        Debug.Log("Player rests!");
        playerActionsUI.SetActive(false);
        HP += MaxHP / 3;
        battleManager.NextTurn();
    }

    public void Attack(Type type = Type.Physical)
    {
        attemptedType = type;
        attemptAction = true;
    }

    public override void TakeDamage(float damageAmount, Type damageType)
    {
        if (invulnerable)
        {
            damageAmount /= 2;
        }
        base.TakeDamage(damageAmount, damageType);
        if (invulnerable)
        {
            spriteRenderer.color = Color.white;
            invulnerable = false;
        }
    }

    //Coroutine for checking if player hits the critical strike on an attack
    //All values are hardcoded for now, not sure if they will change for each attack
    //The totalAttackTime is the time of the animation
    //CritWindowstart and critWindowEnd are when the crit window starts and ends
    //the timeIndic is a temporary UI time indicator for visualizations before animations are finished
    IEnumerator AttackTimingCoroutine()
    {
        float totalAttackTime = 2f;
        float critWindowStart = 0.5f;
        float critWindowEnd = 0.92f;
        float currTime = 0f;
        bool attackHit = false;
        bool chanceUsed = false;
        Vector3 startingPosition = timeIndic.GetComponent<RectTransform>().anchoredPosition;

        attemptAction = false;
        animator.SetTrigger("StartAttack");

        while (currTime < totalAttackTime)
        {
            yield return 0;
            currTime += Time.deltaTime;
            timeIndic.GetComponent<RectTransform>().anchoredPosition = startingPosition + new Vector3((600 * currTime) / totalAttackTime, 0, 0);
            if (currTime > critWindowStart && currTime < critWindowEnd)
            {
                timeIndic.GetComponent<Image>().color = Color.white;
            }
            else
            {
                timeIndic.GetComponent<Image>().color = Color.black;
            }

            //The Player hits the input button
            if (!chanceUsed && attemptAction)
            {
                if (currTime > critWindowStart && currTime < critWindowEnd)
                {
                    Debug.Log(attemptedType.ToString() + " attack performed against " + selectedEnemy.name + "!");
                    animator.SetTrigger("Attack");
                    this.type = attemptedType;
                    attackHit = true;
                    attackCount++;
                }
                else
                {
                    //The Player missed the window
                    Debug.Log("Missed!");
                    if (attackCount < 2) // The last attack can't do damage if you miss
                        selectedEnemy.TakeDamage(0.5f * (10 + Strength - selectedEnemy.Armor), attemptedType);
                    attackCount = 10;
                }
                chanceUsed = true;
            }

            if (enemies.Length < 1)
                attackCount = 10;
        }
        // Debug.Log("finish");

        timeIndic.GetComponent<RectTransform>().anchoredPosition = startingPosition;
        if (!attackHit || 2 < attackCount)
        {
            battleActions.Disable();
            transform.DOMove(playerBase.position, 0.5f);
            battleManager.Invoke("NextTurn", 1f);
            attackCount = 0;
        }
        else
        {
            StartCoroutine(AttackTimingCoroutine());
        }
    }

    /// <summary> The player finds every active enemy on screen </summary>
    public override void GetEnemies()
    {
        GameObject[] currentEnemies = GameObject.FindGameObjectsWithTag("Enemy").Where(e => e.GetComponent<Actor>().enabled).ToArray();

        if (currentEnemies.Length == 0)
        {
            // Victory!
            battleManager.StartCoroutine(battleManager.Victory());
        }
        if (enemies.Length != currentEnemies.Length)
        {
            enemies = new Actor[currentEnemies.Length];
        }

        for(int i = 0; i < currentEnemies.Length; i++)
        {
            enemies[i] = currentEnemies[i].GetComponent<Actor>();
        }

        // So that the currently selected enemy refreshes
        SelectedEnemyNum = SelectedEnemyNum;
    }

    public IEnumerator BlockTimingCoroutine(int damage, Type attackType, Actor owner)
    {
        float totalAttackTime = 3f;
        float critWindowStart = totalAttackTime - 2f / 3f;
        float critWindowEnd = critWindowStart + 1f / 3f;
        float currTime = 0f;
        bool chanceUsed = false;
        Vector3 startingPosition = timeIndic.GetComponent<RectTransform>().anchoredPosition;
        
        attemptAction = false;

        while (currTime < totalAttackTime)
        {
            yield return 0;
            currTime += Time.deltaTime;
            timeIndic.GetComponent<RectTransform>().anchoredPosition = startingPosition + new Vector3((600 * currTime) / totalAttackTime, 0, 0);
            if (currTime > critWindowStart && currTime < critWindowEnd)
            {
                timeIndic.GetComponent<Image>().color = Color.white;
            }
            else
            {
                timeIndic.GetComponent<Image>().color = Color.black;
            }

            //The Player hits the input button
            if (!chanceUsed && attemptAction)
            {
                animator.SetTrigger("Block");
                if (currTime > critWindowStart && currTime < critWindowEnd)
                {
                    Debug.Log("Defended!");
                    invulnerable = true;
                }
                chanceUsed = true;
            }
        }
        // Debug.Log("finish");
        TakeDamage(damage, attackType);
        timeIndic.GetComponent<RectTransform>().anchoredPosition = startingPosition;
        owner.transform.DOMove(owner.startPosition, 0.5f);
        battleManager.Invoke("NextTurn", 1f);
    }

    public override void Die()
    {
        gameObject.SetActive(false);    
    }

    // Called by attack animation
    public void GiveDamage()
    {
        selectedEnemy.TakeDamage(10 + Strength - selectedEnemy.Armor, attemptedType);
    }
}
