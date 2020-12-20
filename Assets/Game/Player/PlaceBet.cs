using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlaceBet
{
    public GameObject money;
    public Money moneyScript;
    public Text betVal;

    public PlaceBet(){
        moneyScript = money.GetComponent<Money>();
        betVal = GameObject.Find("BetValue").GetComponent<InputField>().placeholder.GetComponent<Text>();
    }

    public void PlaceBetAmount(int m){
        if(!moneyScript.ReduceMoney(m)){
            betVal.text = "Bet exceeded";
        }
    }

    public int ReadBetValue(){
        string input = betVal.text;
        try
        {
            int result = Int32.Parse(input);
            return result;
        }
        catch (FormatException)
        {
            betVal.text = "Not Valid";
            return -1;
        }
    }

    public void performAction(){
        int bet = ReadBetValue();
        if(bet != -1){
            PlaceBetAmount(bet);
        }
    }

}
