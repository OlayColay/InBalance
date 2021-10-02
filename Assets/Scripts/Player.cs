using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YounGenTech.HealthScript;

public class Player : Actor
{
    private Health healthScript;

    public int[] elementMeters = {0, 0, 0, 0, 0};

    private int experience;
    public int EXP {
        get;
        set;
    }

    private int nextLevel;
    public int MaxEXP {
        get;
        set;
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

    public void Attack()
    {
        Debug.Log("Player attacks!");
    }
}
