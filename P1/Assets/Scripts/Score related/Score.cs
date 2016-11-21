using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text tekst;
    private int score;

    void Start()
    {
        // zet de score naar 0 en speel een instantie van functie updatescore af om de tekst aan te passen
        score = 0;
        UpdateScore();
    }
    // geeft een in aan die gebruikt word om de score op te tellen
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
    // word aangeroepen om de score te updaten
    void UpdateScore()
    {
        tekst.text = "Score: " + score;
    }
}
