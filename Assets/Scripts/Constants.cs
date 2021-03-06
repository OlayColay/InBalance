using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants : object
{
    public enum Type
    {
        Air,
        Water,
        Earth,
        Fire,
        Electric,
        Physical
    }

    public enum Turn
    {
        Player,
        PlayerToEnemies,
        Enemy1,
        Enemy2,
        Enemy3,
        EnemiesToPlayer,
        None
    }

    /// <summary> Multiplier to damage that is resisted by an Actor's type </summary>
    public static float resistantMultiplier = 0.5f;
    /// <summary> Multiplier to damage that is strengthened by an Actor's type </summary>
    public static float weakMultiplier = 2f;
}
