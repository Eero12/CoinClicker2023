using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float Upgrade1;
    public static float Upgrade2;
    public static float Upgrade3;
    public static bool BoughtUpgrade3;
    public static bool Upgrade2Max;
    public static float money;
    public static float multiplier;
    public static float automultiplier;
    public static float CritPercent;
    public static int randomnumber1;
    public static int randomnumber2;
    public static int CoinFlipRandomNumber1;
    public static int CoinFlipRandomNumber2;
    public static int Range0;
    public static int Range100;
    public static float Clicks;
    public static float startTime;

    void Start()
    {
        Clicks = 0;
        BoughtUpgrade3 = false;
        Upgrade2Max = false;
        Upgrade3 = 0;
        Upgrade1 = 25;
        Upgrade2 = 25;
        multiplier = 1;
        automultiplier = 1;
        money = 0;
        CritPercent = 100;
        Range0 = 0;
        Range100 = 100;
    }


}
