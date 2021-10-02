using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constants;

public class Ability : MonoBehaviour
{
    /// <summary> Type of the ability that the receiving actor could be weak/strong against </summary>
    public virtual Type type {get; set;}

    /// <summary> Base damage of ability that could be affected by user's and target's types and stats </summary>
    public virtual int power {get; set;}

    /// <summary> What the name of the ability is on menus or info screens </summary>
    public virtual string displayName {get; set;}
}
