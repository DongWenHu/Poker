using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dealer : MonoBehaviour
{

    public GameObject[] cards = new GameObject[5];
    private int idx = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void destroyCards(){
        for(int i = 0; i < idx; i++){
            Destroy(cards[i]);
        }
    }

    public void addCard(GameObject card){
        cards[idx] = card;
        idx += 1;
    }

}
