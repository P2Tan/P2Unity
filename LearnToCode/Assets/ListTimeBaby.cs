using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTimeBaby : MonoBehaviour {

    public GameObject cubePrefab;

    GameObject[] cubes = new GameObject[5];

    float spacer = 0.5f;

    // Use this for initialization
    void Start () {

        for (int i = 0; i <cubes.Length; i++){

            GameObject cube = Instantiate(cubePrefab);
            cubes[1] = cube;
            cube.transform.position = new Vector3(i + (spacer * i), cube.transform.position.y);
        }
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
