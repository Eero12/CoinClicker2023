using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class BuyCollectibles : MonoBehaviour, IDataPersistence
{
    public static TextMeshProUGUI Collectible1;
    public static float Collectible1Price = 50;
    public static bool BoughtCollectible1;
    public static TextMeshProUGUI Collectible2;
    public static float Collectible2Price = 100;
    public static bool BoughtCollectible2;
    public static TextMeshProUGUI Collectible3;
    public static float Collectible3Price = 150;
    public static bool BoughtCollectible3;
    public static TextMeshProUGUI Collectible4;
    public static float Collectible4Price = 200;
    public static bool BoughtCollectible4;
    public static TextMeshProUGUI Collectible5;
    public static float Collectible5Price = 250;
    public static bool BoughtCollectible5;

    public void LoadData(GameData data)
    {
        BoughtCollectible1 = data.BoughtCollectible1;
        BoughtCollectible2 = data.BoughtCollectible2;
        BoughtCollectible3 = data.BoughtCollectible3;
        BoughtCollectible4 = data.BoughtCollectible4;
        BoughtCollectible5 = data.BoughtCollectible5;
    }
    public void SaveData(ref GameData data)
    {
        data.BoughtCollectible1 = BoughtCollectible1;
        data.BoughtCollectible2 = BoughtCollectible2;
        data.BoughtCollectible3 = BoughtCollectible3;
        data.BoughtCollectible4 = BoughtCollectible4;
        data.BoughtCollectible5 = BoughtCollectible5;
    }
    public void BuyCollectible1()
    {
        if (GameManager.money >= Collectible1Price && BoughtCollectible1 == false)
        {
            GameManager.money -= Collectible1Price;
            BoughtCollectible1 = true;
            Collectible1.text = "BOUGHT";
        }
    }
public void BuyCollectible2()
    {
        if (GameManager.money >= Collectible2Price && BoughtCollectible2 == false)
        {
            GameManager.money -= Collectible2Price;
            BoughtCollectible2 = true;
            Collectible2.text = "BOUGHT";
        }
    }
    public void BuyCollectible3()
    {
        if (GameManager.money >= Collectible3Price && BoughtCollectible3 == false)
        {
            GameManager.money -= Collectible3Price;
            BoughtCollectible3 = true;
            Collectible3.text = "BOUGHT";
        }
    }
    public void BuyCollectible4()
    {
        if (GameManager.money >= Collectible4Price && BoughtCollectible4 == false)
        {
            GameManager.money -= Collectible4Price;
            BoughtCollectible4 = true;
            Collectible4.text = "BOUGHT";
        }
    }
    public void BuyCollectible5()
    {
        if (GameManager.money >= Collectible5Price && BoughtCollectible5 == false)
        {
            GameManager.money -= Collectible5Price;
            BoughtCollectible5 = true;
            Collectible5.text = "BOUGHT";
        }
    }

}
