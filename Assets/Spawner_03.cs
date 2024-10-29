using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_03 : MonoBehaviour{
    const int NUM_BLOONS = 5;
    [SerializeField] GameObject Bloon;
    void Start(){
        Bloon = GameObject.FindGameObjectWithTag("Bloon");
        Spawn();
    }


    void Update(){
        
    }

    void Spawn(){
        float xMin_01 = 7f, xMax_01 = 8f, yMin_01 = -0.3f, yMax_01 = 0.3f,
               xMin_02 = -2.6f, xMax_02 = -0.3f, yMin_02 = -4f, yMax_02 = -2.5f,
               xMin_03 = -9.2f, xMax_03 = -8.3f, yMin_03 = -4f, yMax_03 = 1f,
               xMin_04 = -7.7f, xMax_04 = 1f, yMin_04 = 4f, yMax_04 = 4.5f;
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
