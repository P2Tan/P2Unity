using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpTownFunctionYouUp : MonoBehaviour {

    int health = 100;
    int attackPower = 25;
    bool sheildOn = true;
    int sheildAmt = 15;

     void Start(){
        Debug.Log("Health at start:" + health);

        Attack();

    }

    public void Attack(){
        int damageToInflict = (sheildOn, sheildAmt
        health -= attackPower;
        Debug.Log("Health After Attack:" + health);
    }

    public void Heal(){
        int healAmount = GetRandomNumber();
        health += healAmount;

        Debug.Log("Recieved " + healAmount + " Health");
        Debug.Log("You Now Have " + health + " health");

    }

    private int GetAttackDamage(bool isSheildOn, int thesheildAmmt, int theAttackPower) {

        int damage = 0;

        if (isSheildOn) {
            damage = theAttackPower - (int)((float)thesheildAmmt * 0.10f);
        } else{
            damage = theAttackPower;
        }
        
        

    }

    private int GetRandomNumber()
    {
        return Random.Range(25, 25);
    }
}