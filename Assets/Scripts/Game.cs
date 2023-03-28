using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.SceneManagement;


public class Game : MonoBehaviour
{
    public Animator Animation;
    public TextMeshProUGUI MoneyCounter;
    public TextMeshProUGUI MoneyCounter2;
    public TextMeshProUGUI MoneyCounter3;
    public TextMeshProUGUI MoneyCounter4;
    public TextMeshProUGUI BetAmount;
    public GameObject ShopCanvas;
    public GameObject GamblingCanvas;
    public GameObject CollectionCanvas;
    public GameObject CollectiblesCanvas;
    public GameObject BusinesssCanvas;
    public TextMeshProUGUI Clicks;
    public AudioSource ClickSound;
    public CriticalClick crit;
    public GameObject critSpawn;
    private float LastAuto;

    public void Increment()
    {
        AudioSource newSource = Instantiate(ClickSound, transform);
        newSource.Play();    
        Destroy(newSource.gameObject, 2f);
        GameManager.Clicks += 1;
        GameManager.randomnumber2 = Random.Range(GameManager.Range0, GameManager.Range100);
        GameManager.randomnumber1 = Random.Range(GameManager.Range0, GameManager.Range100);
        if (GameManager.randomnumber1 == GameManager.randomnumber2)
        {
            GameManager.money += GameManager.multiplier * GameManager.CritPercent;
            GenerateCritText();
            Animation.Play("CriticalClickEffect");
            //Destroy(gameObject, 0.5f);
            Debug.Log("CRITICAL!!");
        }
        else
        {
            
            GameManager.money += GameManager.multiplier;
        }
    }
    public void Update()
    {
        if (GameManager.BoughtUpgrade3 && LastAuto <= Time.time)
        {
            GameManager.money += GameManager.automultiplier;
            LastAuto = Time.time + GameManager.Upgrade3Multiplier;
        }
        if (GameManager.Bought_HotDog && LastAuto <= Time.time)
        {
            GameManager.money += GameManager.HotDog_Amount;
            LastAuto = Time.time + 1;
        }
        Clicks.text = "Clicks " + GameManager.Clicks.ToString("G50");
        MoneyCounter.text = "Money: " + GameManager.money.ToString("G50");
        MoneyCounter2.text = "Money: " + GameManager.money.ToString("G50"); 
        MoneyCounter3.text = "Money: " + GameManager.money.ToString("G50");
        MoneyCounter4.text = "Money: " + GameManager.money.ToString("G50"); 
        BetAmount.text = "Bet: " + GameManager.Gambling_bet.ToString("G50"); 
    }

    #region GAMBLING
    public void CoinFlip()
    {
        GameManager.CoinFlipRandomNumber1 = Random.Range(0, 2);
        GameManager.CoinFlipRandomNumber2 = Random.Range(0, 2);
        if (GameManager.CoinFlipRandomNumber1 == GameManager.CoinFlipRandomNumber2)
        {
            GameManager.money += GameManager.Gambling_bet;
            Debug.Log(GameManager.CoinFlipRandomNumber2);
            Debug.Log(GameManager.CoinFlipRandomNumber1);
        }   
        if (GameManager.CoinFlipRandomNumber1 != GameManager.CoinFlipRandomNumber2)
        {
            Debug.Log(GameManager.CoinFlipRandomNumber2);
            Debug.Log(GameManager.CoinFlipRandomNumber1);
            GameManager.money -= GameManager.Gambling_bet;
            GameManager.Gambling_bet = 0;

        }

    }
    public void Gambling_game1()
    {
        GameManager.Gambling_game1_number1 = Random.Range(0, 3);
        GameManager.Gambling_game1_number2 = Random.Range(0, 3);
        if (GameManager.Gambling_game1_number1 == GameManager.Gambling_game1_number2)
        {
            GameManager.money = GameManager.Gambling_bet * 3;
        }
        if (GameManager.Gambling_game1_number1 != GameManager.Gambling_game1_number2)
        {
            GameManager.money -= GameManager.Gambling_bet;
            GameManager.Gambling_bet = 0;
        }
    }
    public void Gambling_game2()
    {
        GameManager.Gambling_game1_number1 = Random.Range(0, 4);
        GameManager.Gambling_game1_number2 = Random.Range(0, 4);
        if (GameManager.Gambling_game1_number1 == GameManager.Gambling_game1_number2)
        {
            GameManager.money = GameManager.Gambling_bet * 4;
        }
        if (GameManager.Gambling_game1_number1 != GameManager.Gambling_game1_number2)
        {
            GameManager.money -= GameManager.Gambling_bet;
            GameManager.Gambling_bet = 0;
        }
    }
    public void Div_3()
    {
        GameManager.Gambling_bet = Mathf.RoundToInt(GameManager.money / GameManager.Gambling_div3);
    }
    public void Div_2()
    {
        GameManager.Gambling_bet = Mathf.RoundToInt(GameManager.money / GameManager.Gambling_div2);
    }
    public void All_In()
    {
        GameManager.Gambling_bet = GameManager.money;
    }
    #endregion

    #region BUYUPGRADES
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
    #endregion

    #region CANVAS
    public void GenerateCritText()
    {
        var clone = Instantiate(crit, critSpawn.transform);
        clone.Play();
    }
    public void BackToGame()
    {
        ShopCanvas.SetActive(false);
        GamblingCanvas.SetActive(false);
        CollectionCanvas.SetActive(false);
        BusinesssCanvas.SetActive(false);
    }
    public void BackToShop()
    {

        CollectiblesCanvas.SetActive(false);
    }
    public void Shop()
    {
        ShopCanvas.SetActive(true);
    } public void Gambling()
    {
        GamblingCanvas.SetActive(true);
    }public void Collection()
    {
        CollectionCanvas.SetActive(true);
    }public void Collectibles()
    {
        CollectiblesCanvas.SetActive(true);
    }
    public void  Business()
    {
        BusinesssCanvas.SetActive(true);
    }
    #endregion

    #region BUSINESS 
    public float HotDogPrice;
    public void Buy_HotDog()
    {
        GameManager.HotDog_Amount++;
        HotDogPrice -= GameManager.money;
        GameManager.Bought_HotDog = true;
    }



    #endregion


}
