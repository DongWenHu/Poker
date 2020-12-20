using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMoney : MonoBehaviour
{
    // Start is called before the first frame update
    private UnityEngine.UI.Text MoneyValue;
    public GameObject money;
    public Money moneyScript;
    
    public DisplayMoney(){
        MoneyValue = gameObject.GetComponent<UnityEngine.UI.Text>();
        moneyScript = money.GetComponent<Money>();
    }

    public void changeMoneyText(){
        MoneyValue.text = moneyScript.getCurrentMoney().ToString();
    }
    
}
