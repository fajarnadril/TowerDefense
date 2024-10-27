using UnityEngine;
using UnityEngine.UI;

public class Economy : MonoBehaviour
{
    public int Money = 1000;
    public Text MoneyDisplay;
    public int Price;
    public int NewPrice;
    
    public PlaceTower PT;

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
}
