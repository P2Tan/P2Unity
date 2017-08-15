using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional : MonoBehaviour {

    int playerOneTowersRemaining = 2;
    int playerTwoTowersRemaining = 2;

    bool playerOneMainTowerDestroyed = false;
    bool playerTwoMainTowerDestroyed = false;

    float timer = 200;

    //  we're at 17:01
    void Start() {

        if (playerOneMainTowerDestroyed || playerTwoMainTowerDestroyed) {
            if (playerOneMainTowerDestroyed) {
                Debug.Log("player one is doomeed to fail! DunDunDuuuuuuuunnnnnn");
               } else {
                Debug.Log("player two is doomed to fail! DunDunDuuuuuuuunnnnnn");
                }
            Debug.Log("good game bros");
        } else if (timer <= 0)
        {
            if (playerOneTowersRemaining < playerTwoTowersRemaining) {
                Debug.Log("player one is doomeed to fail! DunDunDuuuuuuuunnnnnn");
            }
            else if (playerTwoTowersRemaining < playerOneTowersRemaining)
            {
                Debug.Log("player one is doomeed to fail! DunDunDuuuuuuuunnnnnn");
            } else {
                Debug.Log("you both are doomed to fail!");
            }
        }


        if (true == false || false != true && 1 == 1) { 
            Debug.Log("did we get here?");
        }

    }
    // Update is called once per frame
    void Update() {

    }
}