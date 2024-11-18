using UnityEngine;
using UnityEngine.UI;

public class Economy : MonoBehaviour
{
    public int Money = 1000;
    public Text MoneyDisplay;
    public int Price;
    public int NewPrice;
    
    public PlaceTower PT;
    public GameObject LoseScene;

    public Text HowManyLiveLeft;
    public int Live;

    void Start()
    {
        MoneyDisplay.text = " " + Money.ToString();
    }

    void Update(){
        MoneyDisplay.text = " " + Money.ToString();
    }

    void UpdateMoneyDisplay()
    {
        MoneyDisplay.text = " " + Money.ToString();
    }

    public void SetTowerPrice(int Price){
        NewPrice = Price;
        Money = Money - Price;
        UpdateMoneyDisplay();
        if(Money < 249){
            PT.CannotBuy = true;
        }
    }

    public void EnemyPassed(){
        Live = Live - 1;
        HowManyLiveLeft.text = " " + Live.ToString();
        if(Live == 0){
            LoseScene.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
