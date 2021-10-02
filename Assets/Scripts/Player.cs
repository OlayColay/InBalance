using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using YounGenTech.HealthScript;
using static Constants;

public class Player : Actor
{
    private Health healthScript;
    private Controls.BattleActions battleActions;

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
        battleActions = new Controls().Battle;

        battleActions.Physical.performed += ctx => Attack(Type.Physical);
        battleActions.Air.performed += ctx => Attack(Type.Air);
        battleActions.Water.performed += ctx => Attack(Type.Water);
        battleActions.Earth.performed += ctx => Attack(Type.Earth);
        battleActions.Fire.performed += ctx => Attack(Type.Fire);
        battleActions.Lightning.performed += ctx => Attack(Type.Lightning);
    }

    public void AttackSelected()
    {
        Debug.Log("Player attacks!");
        battleActions.Enable();
    }

    public void Attack(Type type = Type.Physical)
    {
        Debug.Log(type.ToString() + " attack performed!");
    }

    /// <summary> The player finds every active enemy on screen </summary>
    public override void GetEnemies()
    {
        GameObject[] currentEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.Length != currentEnemies.Length)
        {
            enemies = new Actor[currentEnemies.Length];
        }

        for(int i = 0; i < currentEnemies.Length; i++)
        {
            enemies[i] = currentEnemies[i].GetComponent<Actor>();
        }
    }
}
