using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{

    public TextMeshProUGUI Upgrade1Counter;
    public TextMeshProUGUI Upgrade2Counter;
    public TextMeshProUGUI Upgrade3Counter;
    public TextMeshProUGUI MultiplierCounter;
    public Image UpgradeMeter;
    private void Start()
    {
        Debug.Log(1 - (GameManager.Range100 / 100));
    }

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
        Upgrade1Counter.text =  "" + GameManager.Upgrade1;
        MultiplierCounter.text = "Multiplier: " + GameManager.multiplier;
        UpgradeMeter.fillAmount = (float)(1f - (GameManager.Range100 / 100f));

    }
}
