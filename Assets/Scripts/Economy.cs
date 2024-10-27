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
        MoneyDisplay.text = " " + Money.ToString();  // Initialize display with starting money
    }

    void Update(){
        MoneyDisplay.text = " " + Money.ToString();
    }

    void UpdateMoneyDisplay()
    {
        MoneyDisplay.text = " " + Money.ToString(); // Convert money to string for display
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
