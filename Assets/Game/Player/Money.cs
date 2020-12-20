using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money
{
    private int money = 0;
    public Money(int m){
        money = m;
    }

    public bool ReduceMoney(int m){
        if(money - m >= 0){
            money = money-m;
            GameObject.Find("DisplayMoney").SendMessage("changeMoneyText");
            return true;
        }
        return false;
    }

    public void AddMoney(int m){
        GameObject.Find("DisplayMoney").SendMessage("changeMoneyText");
        money += m;
    }

    public int getCurrentMoney(){
        return money;
    }

}
