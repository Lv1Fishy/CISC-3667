using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_01 : MonoBehaviour{
    const int NUM_BLOONS = 5;
    [SerializeField] GameObject Bloon;
    void Start(){
        Bloon = GameObject.FindGameObjectWithTag("Bloon");
        Spawn();
    }


    void Update(){
        
    }

    void Spawn(){
        float xMin_01 = -7, xMax_01 = -3, yMin_01 = -1, yMax_01 = 0,
              xMin_02 = -2, xMax_02 = 2, yMin_02 = 1, yMax_02 = 2,
              xMin_03 = 3, xMax_03 = 7, yMin_03 = -1, yMax_03 = 0;
        Vector2 position;

        for(int i = 0; i < NUM_BLOONS; i++){
            position = new Vector2(Random.Range(xMin_01, xMax_01), Random.Range(yMin_01, yMax_01));
            Instantiate(Bloon, position, Quaternion.identity);
        }
        for(int i = 1; i < NUM_BLOONS; i++){
            position = new Vector2(Random.Range(xMin_02, xMax_02), Random.Range(yMin_02, yMax_02));
            Instantiate(Bloon, position, Quaternion.identity);
        } 
        for(int i = 0; i < NUM_BLOONS; i++){
            position = new Vector2(Random.Range(xMin_03, xMax_03), Random.Range(yMin_03, yMax_03));
            Instantiate(Bloon, position, Quaternion.identity);
        }  
    }
}
