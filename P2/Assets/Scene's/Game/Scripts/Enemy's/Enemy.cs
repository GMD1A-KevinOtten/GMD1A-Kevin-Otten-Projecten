using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public int hp = 3;
    public int points = 10;
    private ScoreManager script;

    void Start()
    {
        GameObject canvasObject = GameObject.FindWithTag("Canvas");
        if (canvasObject != null)
        {
            script = canvasObject.GetComponent<ScoreManager>();
        }
        if (script == null)
        {
            Debug.Log("Cannot find 'Score' script");
        }
    }




    public void DealDamage(int damage)
    {
        hp -= damage;
    }




	void Update ()
    {
	    if (hp <= 0)
        {
            Destroy(gameObject);

            Debug.Log("He ded");

            script.AddScore(points);
        } 
	}
}
