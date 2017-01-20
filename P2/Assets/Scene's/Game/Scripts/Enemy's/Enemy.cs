using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public int hp = 3;
    public int points = 10;
    private ScoreManager script;
    private Transform target;
    private GameObject player;
    public int speed = 2;

    void Start()
    {
        //volg player target asing
        player = GameObject.FindGameObjectWithTag("Player");                // asign player to gameobject
        target = player.transform;                                          // asign component transform of player to target

        //score manger connecten
        GameObject canvasObject = GameObject.FindWithTag("Canvas");         // maak gameobject var aan en asign het canvas daar aan
        script = canvasObject.GetComponent<ScoreManager>();                 // asing script op script var
        
        if (script == null)                                                 // als script niks heeft geeft die in de log een message
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
        float movement = speed * Time.deltaTime * 2;
        transform.position = Vector3.MoveTowards(transform.position, target.position, movement);

	    if (hp <= 0)
        {
            Destroy(gameObject);

            Debug.Log("He ded");

            script.AddScore(points);
        } 
	}
}
