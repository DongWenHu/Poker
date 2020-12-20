using System;
using System.Collections.Generic;

public static class CardEnum
{
    private static Dictionary<int, string> numToCards = new Dictionary<int, string>();
    private static Dictionary<string, int> cardsToNum = new Dictionary<string, int>();
    private static string[] suit = {"Hearts", "Spades", "Clubs", "Diamonds"};
    private static string[] numbers = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};

    static CardEnum(){
        Populate();
    }

    private static void Populate(){

        numToCards.Clear();
        cardsToNum.Clear();
        for(int i = 0; i < 4; i++){
            for(int j = 1; j <= 13; j++){
                string cardString = suit[i] + "_" + numbers[j];
                int cardNum = i*13 + j;
                numToCards.Add(cardNum, cardString);
                cardsToNum.Add(cardString, cardNum);
            }
        }
    }

    public static Dictionary<string, int> cardToNumMap() {
        return cardsToNum;
    }

    public static Dictionary<int, string> numToCardMap() {
        return numToCards;
    }


}