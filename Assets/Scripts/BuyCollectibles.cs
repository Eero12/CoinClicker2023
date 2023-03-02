using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class BuyCollectibles : MonoBehaviour
{
    public TextMeshProUGUI Collectible1;
    public float Collectible1Price = 50;
    public static bool BoughtCollectible1 = false;
    public TextMeshProUGUI Collectible2;
    public float Collectible2Price = 100;
    public static bool BoughtCollectible2 = false;
    public TextMeshProUGUI Collectible3;
    public float Collectible3Price = 150;
    public static bool BoughtCollectible3 = false;
    public TextMeshProUGUI Collectible4;
    public float Collectible4Price = 200;
    public static bool BoughtCollectible4 = false;
    public TextMeshProUGUI Collectible5;
    public float Collectible5Price = 250;
    public static bool BoughtCollectible5= false;


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
