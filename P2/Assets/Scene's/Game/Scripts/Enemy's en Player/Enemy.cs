using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public int hp = 1;
    public int points = 10;
    private ScoreManager script;
    private Transform target;
    private GameObject player;
    public int speed = 2;
    public Spawner spawnerScript;

    void Start()
    {   //spawnpoint script refrencen
        GameObject spawnPoint = GameObject.FindWithTag("SpawnPoint");
        spawnerScript = spawnPoint.GetComponent<Spawner>();

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


    
    //damage van hp afhalen damage is de binnen gekomen variabel
    public void DealDamage(int damage)
    {   
        hp -= damage;
    }




	void Update ()
    {   
        //snelheid van enemys asignen en ze achter de player aan laten gaan
        float movement = speed * Time.deltaTime * 4;
        transform.position = Vector3.MoveTowards(transform.position, target.position, movement);

        //alles dat moet gebeuren op de dood van de enemy
	    if (hp <= 0)
        {
            spawnerScript.enemys.Remove(this.gameObject);

            Destroy(gameObject);

            Debug.Log("He ded");

            script.AddScore(points);
        } 
	}
}
