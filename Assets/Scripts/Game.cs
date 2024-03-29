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
    public TextMeshProUGUI BetAmount;
    public TextMeshProUGUI HotDog_Business_Owned;
    public TextMeshProUGUI Lemonade_Business_Owned;
    public TextMeshProUGUI CarDealer_Owned;
    public TextMeshProUGUI Year_Counter;
    public TextMeshProUGUI LemonadePrice_Counter;
    public TextMeshProUGUI HotDogPrice_Counter;
    public TextMeshProUGUI CarDealerPrice_Counter;
    public GameObject CollectiblesCanvas;
    public GameObject CheckBoxCanvas;
    public GameObject BusinessInfoPanel;
    public TextMeshProUGUI Clicks;
    public AudioSource ClickSound;
    public CriticalClick crit;
    public GameObject critSpawn;
    private float LastAuto_HotDog;
    private float LastAuto_Lemonade;
    private float LastAuto_Car;
    private float LastAuto_Years;

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
            Debug.Log("CRITICAL!!");
        }
        else
        {
            
            GameManager.money += GameManager.multiplier;
        }
    }
    public void Update()
    {
        #region BUSINESS_IF
        if (GameManager.Bought_HotDog && LastAuto_HotDog <= Time.time)
        {
            GameManager.money += GameManager.HotDog_Amount;
            LastAuto_HotDog = Time.time + 1;
        }
        else if (GameManager.Bought_Lemonade && LastAuto_Lemonade <= Time.time)
        {
            GameManager.money += GameManager.Lemonade_Amount + 2;
            LastAuto_Lemonade = Time.time + 2;
        }
        else if (GameManager.Bought_Car && LastAuto_Car <= Time.time)
        {
            GameManager.money += GameManager.Car_Amount + 3;
            LastAuto_Car = Time.time + 3;
        }


        #endregion
        LemonadePrice_Counter.text = LemonadePrice.ToString("G50");
        HotDogPrice_Counter.text = HotDogPrice.ToString("G50");
        CarDealerPrice_Counter.text = CarBusinessPrice.ToString("G50"); 
        Clicks.text = "Clicks " + GameManager.Clicks.ToString("G50");
        MoneyCounter.text = "" + GameManager.money.ToString("G50");
        BetAmount.text = "Bet: " + GameManager.Gambling_bet.ToString("G50");
        HotDog_Business_Owned.text = "HotDog Stands Owned: " + GameManager.HotDog_Amount.ToString("G50");
        Lemonade_Business_Owned.text = "Lemonade Stands Owned: " + GameManager.Lemonade_Amount.ToString("G50");
        CarDealer_Owned.text = "CarDealers Owned: " + GameManager.Car_Amount.ToString("G50");
        Year_Counter.text = GameManager.years + "." + GameManager.months + "." + GameManager.days;

        #region YEARSYSTEM
        if (GameManager.days <= 30 && LastAuto_Years <= Time.time)
        {
            GameManager.days++;
            LastAuto_Years = Time.time + 1;
        }
        switch (GameManager.days)
        {
            case 30:
                GameManager.months++;
                GameManager.days = 1;           
                break;
        }
        switch (GameManager.months)
        {
            case 12:
                GameManager.years++;
                GameManager.months = 1;
                break;
        }


        #endregion

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

    #endregion

    #region CANVAS
    public void GenerateCritText()
    {
        var clone = Instantiate(crit, critSpawn.transform);
        clone.Play();
    }
    public void BackToGame()
    {
        CollectiblesCanvas.SetActive(false);
        CheckBoxCanvas.SetActive(false);
        BusinessInfoPanel.SetActive(false);
    }
    
    public void Collectibles()
    {
        CollectiblesCanvas.SetActive(true);
    }
    public void BusinessPanel()
    {
        BusinessInfoPanel.SetActive(true);
    }
    public void CheckBox()
    {
        CheckBoxCanvas.SetActive(true);
    }
    #endregion

    #region BUSINESS 
    public float LemonadePrice = 150;
    public float HotDogPrice = 300;
    public float CarBusinessPrice = 300;
    public void Buy_HotDog()
    {
        if (HotDogPrice <= GameManager.money)
        {
        GameManager.HotDog_Amount++;
        GameManager.money -= HotDogPrice;
        GameManager.Bought_HotDog = true;
        }
    }
   
    public void Buy_LemonadeStand()
    {
        if (LemonadePrice <= GameManager.money)
        {
            GameManager.Lemonade_Amount++;
            GameManager.money -= LemonadePrice;
            GameManager.Bought_Lemonade = true;
        }
    }

    public void Buy_CarBusiness()
    {
        if (CarBusinessPrice <= GameManager.money)
        {
            GameManager.Car_Amount++;
            GameManager.money -= CarBusinessPrice;
            GameManager.Bought_Car = true;

        }
    }

    #endregion


}
