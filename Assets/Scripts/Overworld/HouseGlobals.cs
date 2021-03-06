using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseGlobals : MonoBehaviour
{
    public static int gateRand;
    public static int plantLevel;
    public const int plantMax = 3;
    public static int bookLevel;
    public const int bookMax = 2;
    public static int yarnLevel;
    public const int yarnMax = 3;
    public static int petLevel;
    public const int petMax = 2;
    public static int waterLevel;
    public const int waterMax = 2;
    public static int cookLevel;
    public const int cookMax = 4;

    public static bool canSleep;

    public Sprite plant2;
    public Sprite plant3;
    public Sprite yarn2;
    public Sprite yarn3;

    private void Awake()
    {
        plantLevel = 0;
        bookLevel = 0;
        yarnLevel = 0;
        petLevel = 0;
        waterLevel = 0;
        cookLevel = 0;

        canSleep = false;
    }

    private void Update()
    {
        if (!canSleep)
        {
            if (plantLevel >= 1 && bookLevel >= 1 && yarnLevel >= 1 &&
            petLevel >= 1 && waterLevel >= 1 && cookLevel >= 1)
            {
                canSleep = true;
            }
        }
        gateRand = Random.Range(0, 4);
    }
}
