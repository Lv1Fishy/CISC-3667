using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Scorekeeper : MonoBehaviour{
    [SerializeField] int score = 0;
    [SerializeField] int level = 1;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI levelText;
    [SerializeField] int CURRENT_STAGE_REQ_SCORE = 15;
    [SerializeField] GameObject controller;

    const int DEFAULT_POINTS = 1;
    void Start(){
        controller = GameObject.FindGameObjectWithTag("GameController");
        DontDestroyOnLoad(controller);
        displayScore();
        displayLevel();
    }

    public void AddPoints(){
        AddPoints(DEFAULT_POINTS);
    }

    public void AddPoints(int points){
        score += points;
        displayScore();
        if(score >= CURRENT_STAGE_REQ_SCORE){
            CURRENT_STAGE_REQ_SCORE += 20;
            level++;
            displayLevel();
            nextLevel();
        }
    }
    
    private void displayScore(){
        scoreText.text = "Score: " + score.ToString();
    }

    private void displayLevel(){
        levelText.text = "Level: " + level.ToString();
    }

    private void nextLevel(){
        SceneManager.LoadScene(level);
    }

}
