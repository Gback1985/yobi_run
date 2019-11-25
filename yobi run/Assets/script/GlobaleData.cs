using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobaleData 
{
    public static bool isGameover = false;
    public static int coinCount = 0;
    public static float distance = 0;

    public static void init()
    {
        isGameover = false;
        coinCount = 0;
        distance = 0;
    }
}
