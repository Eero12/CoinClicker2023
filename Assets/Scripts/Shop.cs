using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{

    public TextMeshProUGUI Upgrade1Counter;
    public TextMeshProUGUI Upgrade2Counter;
    public TextMeshProUGUI Upgrade3Counter;

    void Update()
    {
        if (GameManager.Upgrade2Max)
        {
            Upgrade2Counter.text = "Max";
        }
        if (!GameManager.Upgrade2Max)
        {
            Upgrade2Counter.text = "" + GameManager.Upgrade2;
        }
        if (!GameManager.BoughtUpgrade3)
        {
            Upgrade3Counter.text = "" + GameManager.Upgrade3;

        }
        if (GameManager.BoughtUpgrade3)
        {
            Upgrade3Counter.text = "Max";
        }
        Upgrade1Counter.text = "" + GameManager.Upgrade1;

    }
}
