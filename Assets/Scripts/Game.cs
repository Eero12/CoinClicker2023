using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class Game : MonoBehaviour
{
    public TextMeshProUGUI UI;

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
            GameManager.Upgrade1 = GameManager.Upgrade1 + GameManager.Upgrade1;
        }
    }

    public void Update()
    {
        UI.text = "Money: " + GameManager.money;
    }
}
