using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_02 : MonoBehaviour{
    const int NUM_BLOONS = 5;
    [SerializeField] GameObject Bloon;
    void Start(){
        Bloon = GameObject.FindGameObjectWithTag("Bloon");
        Spawn();
    }


    void Update(){
        
    }

    void Spawn(){
        float xMin_01 = -4.7f, xMax_01 = -2.1f, yMin_01 = -1.4f, yMax_01 = 0f,
               xMin_02 = 0.3f, xMax_02 = 3f, yMin_02 = 0.5f, yMax_02 = 2f,
               xMin_03 = 5.3f, xMax_03 = 7.8f, yMin_03 = 3f, yMax_03 = 4f,
               xMin_04 = 5.3f, xMax_04 = 7.8f, yMin_04 = -3.2f, yMax_04 = -1.8f;
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
        for(int i = 0; i < NUM_BLOONS; i++){
            position = new Vector2(Random.Range(xMin_04, xMax_04), Random.Range(yMin_04, yMax_04));
            Instantiate(Bloon, position, Quaternion.identity);
        }
    }
}
