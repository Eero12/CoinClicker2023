using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, IDataPersistence
{
    public static string playername;
    public static float Upgrade1;
    public static float Upgrade2;
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
    public static bool Bought_Car;
    public static int Car_Amount;
    public static int HotDog_Amount;
    public static bool Bought_Lemonade;
    public static int Lemonade_Amount;
    public static float days;
    public static float months;
    public static float years;


    public void LoadData(GameData data)
    {
        playername = data.playername;
        days = data.days;
        months = data.months;
        years = data.years;
        Car_Amount = data.Car_Amount;
        Lemonade_Amount = data.Lemonade_Amount;
        HotDog_Amount = data.HotDog_Amount;
        Bought_HotDog = data.Bought_HotDog;

        Bought_Car = data.Bought_Car;
        Car_Amount = data.Car_Amount;

        Gambling_bet = 0;
        Gambling_div2 = 2;
        Gambling_div3 = 3;
        Gambling_AllIn = money;
        Clicks =data.clicks;
        money = data.money;
        Upgrade2Max = data.Upgrade2Max;
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
        data.playername = playername;
        data.days = days;
        data.months = months;
        data.years = years;

        data.Car_Amount = Car_Amount;
        data.Bought_Car = Bought_Car;

        data.Bought_Lemonade = Bought_Lemonade;
        data.Lemonade_Amount = Lemonade_Amount;
        data.HotDog_Amount = HotDog_Amount;
        data.Bought_HotDog = Bought_HotDog;
        data.clicks = Clicks;
        data.money = money;
        data.Upgrade2Max = Upgrade2Max;
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
