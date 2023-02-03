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

    public void Buy(float num)
    {
        if(num == 1 && GameManager.money >= 25) 
        {
            GameManager.multiplier += 1;
            GameManager.money -= 25;
        }
    }

    public void Update()
    {
        UI.text = "Money: " + GameManager.money;
    }
}
