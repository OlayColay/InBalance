using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constants;

public class Actor : MonoBehaviour
{
    public BattleManager battleManager;

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

    [SerializeField] protected int armor = 100;
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

    [SerializeField] protected int wisdom = 100;
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

    [SerializeField] protected int resist = 100;
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

    private void Start()
    {
        GetEnemies();
    }

    /// <summary> Actor has HP reduced depending on element of the attack </summary>
    public void TakeDamage(float damageAmount, Type damageType)
    {
        if (isStrongAgainst(damageType))
            this.HP -= (int)(damageAmount * resistantMultiplier);
        else if (isWeakAgainst(damageType))
            this.HP -= (int)(damageAmount * weakMultiplier);
        else
            this.HP -= (int)damageAmount;
    }

    /// <summary> Return true if the actor is resistant to the opposingType </summary>
    public bool isStrongAgainst(Type opposingType)
    {
        switch(type)
        {
            case Type.Air:
                return opposingType == Type.Water || opposingType == Type.Earth;
            case Type.Water:
                return opposingType == Type.Earth || opposingType == Type.Fire;
            case Type.Earth:
                return opposingType == Type.Fire || opposingType == Type.Lightning;
            case Type.Fire:
                return opposingType == Type.Lightning || opposingType == Type.Air;
            case Type.Lightning:
                return opposingType == Type.Air || opposingType == Type.Water;
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
                return opposingType == Type.Fire || opposingType == Type.Lightning;
            case Type.Water:
                return opposingType == Type.Lightning || opposingType == Type.Air;
            case Type.Earth:
                return opposingType == Type.Air || opposingType == Type.Water;
            case Type.Fire:
                return opposingType == Type.Water || opposingType == Type.Earth;
            case Type.Lightning:
                return opposingType == Type.Earth || opposingType == Type.Fire;
            default:
                return false;
        }
    }

    /// <summary> Enemies pick a random ability of theirs to attack with </summary>
    public virtual void Attack()
    {
        int rand = Random.Range(0, abilities.Length);
        abilities[rand].Use();
    }
    
    /// <summary> Enemies will just get the player as their enemy </summary>
    public virtual void GetEnemies()
    {
        if (enemies.Length < 1)
            enemies = new Player[1];
        enemies[0] = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    /// <summary> This is called when the Actor's HP is 0 </summary>
    public virtual void Die()
    {
        gameObject.SetActive(false);

        foreach (Actor enemy in enemies)
        {
            enemy.GetEnemies();
        }
    }
}
