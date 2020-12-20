using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fold
{

    public GameObject player;

    public void performAction(){
        // destroy players cards....
        player.SendMessage("destroyCards");
    }

    
}
