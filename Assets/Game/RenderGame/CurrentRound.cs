using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentRound : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] players;
    public int[] bets;
    public GameObject currentPlayer;
    public GameObject currentRound;
    public GameObject dealer;
    public int currentPlayerId = 0;
    public volatile bool clicked;
    private float timer = 60f;
    private int matchBet = 0;
    private CardsDeck deck;


    public CurrentRound(GameObject[] p, GameObject c, GameObject d){
        players = p;
        clicked = false;
        bets = new int[players.Length];
        for(int i = 0; i < players.Length; i++){
            bets[i] = 0;
        }
        currentRound = c;
        dealer = d;
        deck = new CardsDeck();
        for(int j = 0; j < players.Length; j++){
            if(players[j] != null){
                GameObject card = deck.getNextCard();
                players[j].SendMessage("addCard",card);
            }
        }
        dealCards(3);
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(clicked){
            moveToNextPlayer();
            clicked = false;
            timer = 60f;
        } else if (timer <= 0){
            Fold();
            moveToNextPlayer();
            timer = 60f;
        }
    }


    public void Fold(){
        bets[currentPlayerId] = -1;
        currentPlayer.SendMessage("destroyCards");
    }

    public void moveToNextPlayer(){
        int i = currentPlayerId + 1;
        for(; i <= players.Length; i++){
            if(i == players.Length){
                i = 0;
                dealCards(1);
            }
            if(players[i] != null){
                break;
            }
        }
        if(i == currentPlayerId){
            declareWinner();
        } else {
            currentPlayer = players[i];
            currentPlayerId = i;
        }
    }

    public void dealCards(int numCards){
        dealer.SendMessage("showCards");       
        
        for(int i = 0; i < numCards; i++){
            GameObject c = deck.getNextCard();
            dealer.SendMessage("addCard", c);
        }
    }

    public void declareWinner(){
        currentPlayer.SendMessage("destroyCards");
        destroyRound();
    }

    public void processPlayerMove(int bet, bool fold){
        if(!fold){
            // player cost has been reduced by appropriate function
            // change bets to include this newly placed bet
            //

        }
        Clicked(fold);
    }

    public void Clicked(bool fold){
        if(fold){
            clicked = true;
            Fold();
        } else {
            clicked = true;
        }
    }

    public GameObject destroyRound(){
        Destroy(currentRound);
        return currentPlayer;
    }

}
