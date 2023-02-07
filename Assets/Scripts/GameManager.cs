using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float Upgrade1;
    public static float Upgrade2;
    public static float money;
    public static float multiplier;
    public static float CritPercent;
    public static int randomnumber1;
    public static int randomnumber2;
    public static int Range0;
    public static int Range100;
    public static int range100;
    void Start()
    { 
        Upgrade1 = 25;
        Upgrade2 = 25;
        multiplier = 1;
        money = 0;
        CritPercent = 100;
        Range0 = 0;
        Range100 = 100;
        range100 = 100;
    }


}
