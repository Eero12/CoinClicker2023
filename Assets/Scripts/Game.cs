using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.SceneManagement;


public class Game : MonoBehaviour
{
    public TextMeshProUGUI MoneyCounter;
    public GameObject ShopCanvas;
    public TextMeshProUGUI Clicks;
    

    public void Increment()
    {
        GameManager.Clicks += 1;
        GameManager.randomnumber2 = Random.Range(GameManager.Range0, GameManager.Range100);
        GameManager.randomnumber1 = Random.Range(GameManager.Range0, GameManager.Range100);
        if (GameManager.randomnumber1 == GameManager.randomnumber2)
        {
            GameManager.money += GameManager.multiplier * GameManager.CritPercent;
            Debug.Log("CRITICAL!!");
        }
        else
        {
            
            GameManager.money += GameManager.multiplier;
        }
    }
    public void Values()
    {        
        Debug.Log("RandomNumber1: " + GameManager.randomnumber1);
        Debug.Log("RandomNumber2: " + GameManager.randomnumber2);
        Debug.Log("Range is: " + GameManager.Range100);
        Debug.Log("Upgrade2 value: " + GameManager.Upgrade2Max);
    }
    public void CoinFlip()
    {
        GameManager.CoinFlipRandomNumber1 = Random.Range(0, 2);
        GameManager.CoinFlipRandomNumber2 = Random.Range(0, 2);
        if (GameManager.CoinFlipRandomNumber1 == GameManager.CoinFlipRandomNumber2)
        {
            GameManager.money += GameManager.money;
            Debug.Log(GameManager.CoinFlipRandomNumber2);
            Debug.Log(GameManager.CoinFlipRandomNumber1);
        }   
        if (GameManager.CoinFlipRandomNumber1 != GameManager.CoinFlipRandomNumber2)
        {
            Debug.Log(GameManager.CoinFlipRandomNumber2);
            Debug.Log(GameManager.CoinFlipRandomNumber1);
            GameManager.money = 0;
        }

    }
    public void BuyUpgrade1()
    {        
        if(GameManager.money >= GameManager.Upgrade1) 
        {
            GameManager.multiplier += 1;
            GameManager.money -= GameManager.Upgrade1;
            GameManager.Upgrade1 += 50;
        }
    }
    public void BuyUpgrade2()
    {        

        if(GameManager.money >= GameManager.Upgrade2 && !GameManager.Upgrade2Max) 
        {
            GameManager.Range100 -= 5;
            GameManager.money -= GameManager.Upgrade2;
            GameManager.Upgrade2 += 100;
            if (GameManager.Range100 <= 0)
            {
                GameManager.Range100 = 0;
                GameManager.Upgrade2Max = true;
            }
        }

    }
    public void BuyUpgrade3()
    {        
        if(GameManager.money >= GameManager.Upgrade3 && GameManager.BoughtUpgrade3 == false) 
        {
            GameManager.money -= GameManager.Upgrade3;
            GameManager.BoughtUpgrade3 = true;   
        }
    }  

    public void BackToGame()
    {
        ShopCanvas.SetActive(false);
    }
    public void Shop()
    {
        ShopCanvas.SetActive(true);
    }

    public void Update()
    {
        GameManager.startTime = Time.time + 0.5f;
        Clicks.text = "Clicks " + GameManager.Clicks;
        MoneyCounter.text = "Money: " + GameManager.money;
    }
}
