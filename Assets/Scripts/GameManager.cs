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
    public static float Gambling_bet;
    public static float Gambling_div3;
    public static float Gambling_div2;
    public static float Gambling_AllIn;
    public static int Gambling_game1_number1;
    public static int Gambling_game1_number2;
    public static bool Bought_HotDog;
    public static int HotDog_Amount;

    public void LoadData(GameData data)
    {
        HotDog_Amount = data.HotDog_Amount;
        Bought_HotDog = data.Bought_HotDog;
        Gambling_bet = 0;
        Gambling_div2 = 2;
        Gambling_div3 = 3;
        Gambling_AllIn = money;
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
        BuyCollectibles.BoughtCollectible1 = data.BoughtCollectible1;
        BuyCollectibles.BoughtCollectible2 = data.BoughtCollectible2;
        BuyCollectibles.BoughtCollectible3 = data.BoughtCollectible3;
        BuyCollectibles.BoughtCollectible4 = data.BoughtCollectible4;
        BuyCollectibles.BoughtCollectible5 = data.BoughtCollectible5;
        BuyCollectibles.Collectible1Price = data.Collectible1Price;
        BuyCollectibles.Collectible2Price = data.Collectible2Price;
        BuyCollectibles.Collectible3Price = data.Collectible3Price;
        BuyCollectibles.Collectible4Price = data.Collectible4Price;
        BuyCollectibles.Collectible5Price = data.Collectible5Price;

    }

    public void SaveData(ref GameData data)
    {
        data.HotDog_Amount = HotDog_Amount;
        data.Bought_HotDog = Bought_HotDog;
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
        data.BoughtCollectible1 = BuyCollectibles.BoughtCollectible1;
        data.BoughtCollectible2 = BuyCollectibles.BoughtCollectible2;
        data.BoughtCollectible3 = BuyCollectibles.BoughtCollectible3;
        data.BoughtCollectible4 = BuyCollectibles.BoughtCollectible4;
        data.BoughtCollectible5 = BuyCollectibles.BoughtCollectible5;
        data.Collectible1Price = BuyCollectibles.Collectible1Price;
        data.Collectible2Price = BuyCollectibles.Collectible2Price;
        data.Collectible3Price = BuyCollectibles.Collectible3Price;
        data.Collectible4Price = BuyCollectibles.Collectible4Price;
        data.Collectible5Price = BuyCollectibles.Collectible5Price;


    }
}
