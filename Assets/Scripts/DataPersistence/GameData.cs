using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    public float clicks;
    public float money;
    public float Upgrade3Multiplier;
    public bool BoughtUpgrade3;
    public bool Upgrade2Max;
    public float Upgrade3;
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

    //tässä scriptissä ilmoitetaan pelin alussa voimassa olevat arvot.

    public GameData()
    {
        this.clicks = 0;
        this.money = 0;
        this.Upgrade3Multiplier = 1;
        this.BoughtUpgrade3 = false;
        this.Upgrade2Max = false;
        this.Upgrade3 = 200;
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

    }
}

