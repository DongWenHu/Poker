using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObject : MonoBehaviour
{

    private int numPlayerCards = 2;
    public GameObject[] cards = new GameObject[2];
    private int idx = 0;

    void start(){

    }

    void update(){


    }
    public void destroyCards(){
        for(int i = 0; i < numPlayerCards; i++){
            Destroy(cards[i]);
        }
    }

    public void addCard(GameObject card){
        cards[idx] = card;
        idx += 1;
    }

}
