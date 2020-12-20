using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards
{
    
    // private Dictionary<int, string> numToCards = new Dictionary<int, string>();
    // private Dictionary<string, int> cardsToNum = new Dictionary<string, int>();

    private int[] indices = new int[52];
    private int idx = 0;
    
    public Cards(){
        
        for(int i = 0; i < 52; i++){
            indices[i] = i;
        }
        System.Random temp = new System.Random();
        Shuffle(indices, temp);

    }

    private void Shuffle(int[] list, System.Random rnd){
        for(var i=list.Length; i > 0; i--){
            int j = rnd.Next(0, i);
            var temp = list[0];
            list[0] = list[j];
            list[j] = temp;
        }
    }

    // public bool RemoveCard(string card){
    //     if(cardsToNum.ContainsKey(card)){
    //         numToCards.Remove(cardsToNum[card]);
    //         cardsToNum.Remove(card);  
    //         return true;
    //     }
    //     return false;
    // }

    // public bool RemoveCard(int num){
    //     if(numToCards.ContainsKey(num)){
    //         cardsToNum.Remove(numToCards[num]);
    //         numToCards.Remove(num);  
    //         return true;
    //     }
    //     return false;
    // }

    public int SelectRandomCard(){
        
        if(idx == 52){
            return -1;
        }
        
        idx += 1;
        return indices[idx-1];
    }

}
