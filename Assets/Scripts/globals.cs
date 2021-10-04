using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globals
{
    public static List<string> currQuests;
    
    /// <summary> Array of experience for player's elements </summary>
    public static int[] elementExperience = {0, 0, 0, 0, 0, 0};

    /// <summary> Array that experience has to reach to level up </summary>
    public static int[] nextLevel = {5, 5, 5, 5, 5, 5};

    /// <summary> Element meters of the player </summary>
    public static int[] elementMeters = {0, 0, 0, 0, 0, 0};
}
