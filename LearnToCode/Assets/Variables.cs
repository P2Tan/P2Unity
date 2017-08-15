using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string heroName = "Thanos";
        string equippedWeapon = "Infinity Gauntlet";
        string favoriteFurniture = "Throne";

        string favoritePlanet;

        favoritePlanet = "Earth";

        Debug.Log(favoritePlanet);

        Debug.Log (heroName);
        Debug.Log(equippedWeapon);
        Debug.Log(favoriteFurniture);

        Debug.Log(equippedWeapon.ToUpper());

        int hp = 100;
        float sheildPower = 76.5F;
        int LaserDamage = 30;
        double actualDamagePercent = .05;

        int actualDamage = (int)(LaserDamage * actualDamagePercent);

        hp -= actualDamage; //hp = hp - ActualDamage

        sheildPower = sheildPower - (LaserDamage - actualDamage);

        Debug.Log("HP: " + hp);
        Debug.Log("Shield Power: " + sheildPower);

        int slices = 10 / 5;

        print (slices);

        int newDamage = 10 / 3;

        print(newDamage);

        int newDamageRemainder = 10 % 3;

        print("10 divided by 3 equals " + newDamage + " with a remainder of " + newDamageRemainder);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}