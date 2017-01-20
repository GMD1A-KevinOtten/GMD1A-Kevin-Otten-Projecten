using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text score;
    public int points;

    void Start()
    {
        points = 0;
        UpdateScore();
    }

    public void AddScore(int newScoreValue)
    {
        points += newScoreValue;
        UpdateScore();
    }

    void Update()
    {

    }

    void UpdateScore()
    {
        score.text = "Score: " + points;
    }
}
