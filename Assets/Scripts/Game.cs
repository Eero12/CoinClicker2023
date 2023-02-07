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

    public void Increment()
    {
        GameManager.money += GameManager.multiplier;
    }

    public void Buy()
    {
        Debug.Log(GameManager.Upgrade1);
        if(GameManager.money >= GameManager.Upgrade1) 
        {
            GameManager.multiplier += 1;
            GameManager.money -= GameManager.Upgrade1;
            GameManager.Upgrade1 += 50;
        }
    }

    public void Update()
    {
        MoneyCounter.text = "Price: " + GameManager.Upgrade1;
        Upgrade1Counter.text = "Money: " + GameManager.money;
    }
}
