using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constants;

public class Actor : MonoBehaviour
{
    protected int health = 100;
    /// <summary> Health points of the actor </summary>
    public virtual int HP {
        get 
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    protected int maxHealth = 100;
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

    protected int strength = 10;
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

    protected int armor = 100;
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

    protected int wisdom = 100;
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

    protected int resist = 100;
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
}
