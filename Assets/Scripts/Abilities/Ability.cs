using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constants;

public class Ability : MonoBehaviour
{
    /// <summary> Type of the ability that the receiving actor could be weak/strong against </summary>
    public Type type = Type.Physical;

    /// <summary> Base damage of ability that could be affected by user's and target's types and stats </summary>
    public int power = 10;

    /// <summary> What the name of the ability is on menus or info screens </summary>
    public string displayName = "Basic Physical";
    
    /// <summary> Use the ability on the Actor's enemy </summary>
    public void Use(Actor owner, Actor target)
    {
        // target.TakeDamage(power + owner.Strength - target.Armor, type);
    }
}
