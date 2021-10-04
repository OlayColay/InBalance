using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using static Constants;

public class Actor : MonoBehaviour
{
    protected BattleManager battleManager;
    public SpriteRenderer spriteRenderer;

    [SerializeField] protected int health = 100;
    /// <summary> Health points of the actor </summary>
    public virtual int HP {
        get 
        {
            return health;
        }
        set
        {
            health = value;

            if (health < 1)
            {
                Die();
            }
        }
    }

    [SerializeField] protected int maxHealth = 100;
    /// <summary> Maximum health points of the actor </summary>
    public virtual int MaxHP {
        get 
        {
            return maxHealth;
        }
        set
        {
            maxHealth = value;
        }
    }

    [SerializeField] protected int strength = 10;
    /// <summary> Physical attack of the actor </summary>
    public int Strength {
        get 
        {
            return strength;
        }
        set
        {
            strength = value;
        }
    }

    [SerializeField] protected int armor = 10;
    /// <summary> Physical defense of the actor </summary>
    public int Armor {
        get 
        {
            return armor;
        }
        set
        {
            armor = value;
        }
    }

    [SerializeField] protected int wisdom = 10;
    /// <summary> Elemental attack of the actor </summary>
    public int Wisdom {
        get 
        {
            return wisdom;
        }
        set
        {
            wisdom = value;
        }
    }

    [SerializeField] protected int resist = 10;
    /// <summary> Elemental defense of the actor </summary>
    public int Resist {
        get 
        {
            return resist;
        }
        set
        {
            resist = value;
        }
    }

    /// <summary> Type of the actor that affects which attacks are strong or weak against the actor </summary>
    public Type type;

    /// <summary> Array of an Actor's abilities </summary>
    public Ability[] abilities;

    /// <summary> Array of an Actor's enemies (for enemies, it's just the player) </summary>
    public Actor[] enemies;

    /// <summary> If the actor is currently attacking </summary>
    public bool isAttacking = false;

    public Vector3 startPosition;

    private void Start()
    {
        battleManager = GameObject.FindObjectOfType<BattleManager>();
        GetEnemies();
    }

    /// <summary> Actor has HP reduced depending on element of the attack </summary>
    public virtual bool TakeDamage(float damageAmount, Type damageType)
    {
        int oldHP = this.HP;
        if (isStrongAgainst(damageType))
            this.HP -= (int)(damageAmount * resistantMultiplier);
        else if (isWeakAgainst(damageType))
            this.HP -= (int)(damageAmount * weakMultiplier);
        else
            this.HP -= (int)damageAmount;

        if (oldHP < this.HP)
            spriteRenderer.color = Color.green;
        else if (this.HP < oldHP)
            spriteRenderer.color = Color.red;
        Invoke("ResetColor", 0.5f);

        return this.HP < 1;
    }

    private void ResetColor()
    {
        spriteRenderer.color = Color.white;
    }

    /// <summary> Return true if the actor is resistant to the opposingType </summary>
    public bool isStrongAgainst(Type opposingType)
    {
        switch(type)
        {
            case Type.Air:
                return opposingType == Type.Water || opposingType == Type.Earth || opposingType == Type.Air;
            case Type.Water:
                return opposingType == Type.Earth || opposingType == Type.Fire || opposingType == Type.Water;
            case Type.Earth:
                return opposingType == Type.Fire || opposingType == Type.Electric || opposingType == Type.Earth;
            case Type.Fire:
                return opposingType == Type.Electric || opposingType == Type.Air || opposingType == Type.Fire;
            case Type.Electric:
                return opposingType == Type.Air || opposingType == Type.Water || opposingType == Type.Electric;
            default:
                return false;
        }
    }

    /// <summary> Return true if the actor is weak to the opposingType </summary>
    public bool isWeakAgainst(Type opposingType)
    {
        switch(type)
        {
            case Type.Air:
                return opposingType == Type.Fire || opposingType == Type.Electric;
            case Type.Water:
                return opposingType == Type.Electric || opposingType == Type.Air;
            case Type.Earth:
                return opposingType == Type.Air || opposingType == Type.Water;
            case Type.Fire:
                return opposingType == Type.Water || opposingType == Type.Earth;
            case Type.Electric:
                return opposingType == Type.Earth || opposingType == Type.Fire;
            default:
                return false;
        }
    }

    /// <summary> Enemies pick a random ability of theirs to attack with </summary>
    public virtual void Attack()
    {
        startPosition = transform.position;
        transform.DOMove(enemies[0].transform.GetChild(0).position, 0.5f);
        int rand = Random.Range(0, abilities.Length);
        abilities[rand].Use(this, enemies[0]);
        enemies[0].StartCoroutine(enemies[0].GetComponent<Player>().BlockTimingCoroutine(abilities[rand].power + Strength - enemies[0].Armor, type, this));
        Debug.Log(abilities[rand].displayName + " used against " + enemies[0].name + "!");
        // transform.DOMove(startPosition, 0.5f);
    }
    
    /// <summary> Enemies will just get the player as their enemy </summary>
    public virtual void GetEnemies()
    {
        if (enemies.Length < 1)
            enemies = new Player[1];
        enemies[0] = GameObject.FindObjectOfType<Player>();
    }

    /// <summary> This is called when the Actor's HP is 0 </summary>
    public virtual void Die()
    {
        transform.DOMoveY(transform.position.y - 1, 0.5f);
        spriteRenderer.DOFade(0f, 0.5f);
        Invoke("SetDead", 0.5f);
    }

    private void SetDead()
    {
        Destroy(this.gameObject);

        foreach (Actor enemy in enemies)
        {
            enemy.GetEnemies();
        }
    }
}
