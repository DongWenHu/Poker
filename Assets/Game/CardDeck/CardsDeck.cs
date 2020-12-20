using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsDeck : MonoBehaviour
{
    public GameObject[] cards;
    private Cards c;
    private Vector3 startPos = new Vector3(0, 0, 0);

    public CardsDeck(){
        generateCardDeck();
    }

    public void generateCardDeck(){
        c = new Cards();
    }

    public GameObject getNextCard(){
        int cardNum = c.SelectRandomCard();
        GameObject obj = Instantiate(cards[cardNum], startPos, cards[cardNum].transform.rotation);
        return obj;
    }



}
