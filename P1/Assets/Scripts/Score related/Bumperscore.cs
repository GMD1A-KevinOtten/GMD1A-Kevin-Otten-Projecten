using UnityEngine;
using System.Collections;

public class Bumperscore : MonoBehaviour {

    public int scoreValue;
    private Score score1;

    //nodig om het script het varibel te laten afgeven
    void Start()
    {
        GameObject canvasObject = GameObject.FindWithTag("Canvas");
        if (canvasObject != null)
        {
            score1 = canvasObject.GetComponent<Score>();
        }
        if (score1 == null)
        {
            Debug.Log("Cannot find 'Score' script");
        }
    }

    // voert score aan andere script
    void OnCollisionEnter(Collision collision)
    {
        score1.AddScore(scoreValue);
    }
}
