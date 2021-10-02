using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants : object
{
    public enum Type
    {
        Physical,
        Air,
        Water,
        Earth,
        Fire,
        Lightning
    }

    /// <summary> Multiplier to damage that is resisted by an Actor's type </summary>
    public static float resistantMultiplier = 0.5f;
    /// <summary> Multiplier to damage that is strengthened by an Actor's type </summary>
    public static float weakMultiplier = 2f;
}
