using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, IDataPersistence
{
    public static float Upgrade1;
    public static float Upgrade2;
    public static float Upgrade3;
    public static bool BoughtUpgrade3;
    public static float Upgrade3Multiplier;
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

    public void LoadData(GameData data)
    {
        Clicks =data.clicks;
        money = data.money;
        Upgrade3Multiplier = data.Upgrade3Multiplier;
        BoughtUpgrade3 = data.BoughtUpgrade3;
        Upgrade2Max = data.Upgrade2Max;
        Upgrade3 = data.Upgrade3;
        Upgrade1 = data.Upgrade1;
        Upgrade2 = data.Upgrade2;
        multiplier = data.multiplier;
        automultiplier = data.automultiplier;
        CritPercent = data.CritPercent;
        Range0 = data.Range0;
        Range100 = data.Range100;
    }

    public void SaveData(ref GameData data)
    {
        data.clicks = Clicks;
        data.money = money;
        data.Upgrade3Multiplier = Upgrade3Multiplier;
        data.BoughtUpgrade3 = BoughtUpgrade3;
        data.Upgrade2Max = Upgrade2Max;
        data.Upgrade3 = Upgrade3;
        data.Upgrade1 = Upgrade1;
        data.Upgrade2 = Upgrade2;
        data.multiplier = multiplier;
        data.automultiplier = automultiplier;
        data.CritPercent = CritPercent;
        data.Range0 = Range0;
        data.Range100 = Range100;
    }



}
