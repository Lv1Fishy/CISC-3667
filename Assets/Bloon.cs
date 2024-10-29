using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bloon : MonoBehaviour{
    [SerializeField] AudioSource soundbit;
    [SerializeField] GameObject controller;
    [SerializeField] Vector2 scale;

    void Start(){
        if (controller == null){
            controller = GameObject.FindGameObjectWithTag("GameController");
        }
        if (soundbit == null)
            soundbit = GetComponent<AudioSource>();

        InvokeRepeating("growInSize", 1.0f, 0.1f);
        
    }

    void Update(){
        
    }

    private void growInSize(){
        scale = transform.localScale;
        scale.x += 0.003f;
        scale.y += 0.003f;
        transform.localScale = scale;
        if(scale.x >= 0.5f){
            GameObject reset = GameObject.FindGameObjectWithTag("GameController");
            Destroy(reset);
            SceneManager.LoadScene(1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            controller.GetComponent<Scorekeeper>().AddPoints();
            AudioSource.PlayClipAtPoint(soundbit.clip, transform.position);
            Destroy(gameObject);
        }
    }
}
