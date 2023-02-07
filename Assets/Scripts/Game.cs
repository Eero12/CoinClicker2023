using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class Game : MonoBehaviour
{
    public TextMeshProUGUI MoneyCounter;
    public TextMeshProUGUI Upgrade1Counter;
    public TextMeshProUGUI Upgrade2Counter;

    public void Increment()
    {
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
    public void BuyUpgrade1()
    {        
        if(GameManager.money >= GameManager.Upgrade1) 
        {
            GameManager.multiplier += 1;
            GameManager.money -= GameManager.Upgrade1;
            GameManager.Upgrade1 += 50;
        }
    }  public void BuyUpgrade2()
    {        

        if(GameManager.money >= GameManager.Upgrade2 && !GameManager.Upgrade2Max) 
        {
            GameManager.Range100 -= 10;
            GameManager.money -= GameManager.Upgrade2;
            //GameManager.Upgrade2 += 50;
            if (GameManager.Range100 <= 0)
            {
                GameManager.Range100 = 0;
                GameManager.Upgrade2Max = true;
            }
        }

    }

    public void Update()
    {     
        if (GameManager.Upgrade2Max)
        {
            Upgrade2Counter.text = "Max";
        }
        if (!GameManager.Upgrade2Max)
        {
        Upgrade2Counter.text = ""+GameManager.Upgrade2;
        }
        MoneyCounter.text = "Money: " + GameManager.money;
        Upgrade1Counter.text = ""+GameManager.Upgrade1;
    }
}
