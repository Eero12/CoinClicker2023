using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]

public class GameData
{
    public bool Bought_HotDog;
    public bool Bought_Lemonade;
    public int HotDog_Amount;
    public int Lemonade_Amount;
    public float clicks;
    public float money;
    public bool Upgrade2Max;
    public float Upgrade1;
    public float Upgrade2;
    public float multiplier;
    public float automultiplier;
    public float CritPercent;
    public int Range0;
    public int Range100;
    public bool BoughtCollectible1;
    public bool BoughtCollectible2;
    public bool BoughtCollectible3;
    public bool BoughtCollectible4;
    public bool BoughtCollectible5;
    public float Collectible1Price;
    public float Collectible2Price;
    public float Collectible3Price;
    public float Collectible4Price;
    public float Collectible5Price;
    public float days;
    public float months;
    public float years;


    //t�ss� scriptiss� ilmoitetaan pelin alussa voimassa olevat arvot.

    public GameData()
    {
        this.days = 1;
        this.months = 1;
        this.years = 2023;
        this.Lemonade_Amount = 0;
        this.Bought_Lemonade = false;
        this.HotDog_Amount = 0;
        this.Bought_HotDog = false;
        this.clicks = 0;
        this.money = 0;
        this.Upgrade2Max = false;
        this.Upgrade1 = 25;
        this.Upgrade2 = 25;
        this.multiplier = 1;
        this.automultiplier = 1;
        this.CritPercent = 100;
        this.Range0 = 0;
        this.Range100 = 100;
        this.BoughtCollectible1 = false;
        this.BoughtCollectible2 = false;
        this.BoughtCollectible3 = false;
        this.BoughtCollectible4 = false;
        this.BoughtCollectible5 = false;
        this.Collectible1Price = 50;
        this.Collectible2Price = 100;
        this.Collectible3Price = 150;
        this.Collectible4Price = 200;
        this.Collectible5Price = 250;

    }
}

