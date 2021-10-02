using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constants;

public abstract class Ability : MonoBehaviour
{
    /// <summary> Type of the ability that the receiving actor could be weak/strong against </summary>
    public abstract Type type {get;}

    /// <summary> Base damage of ability that could be affected by user's and target's types and stats </summary>
    public abstract int power {get;}

    /// <summary> What the name of the ability is on menus or info screens </summary>
    public abstract string displayName {get;}
}
