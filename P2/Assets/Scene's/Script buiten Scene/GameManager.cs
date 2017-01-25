using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public EnemySpawner spawnScript;
    public static GameManager gm;
	



	void Start ()
    {
        //als gm niks is word het dit anders als gm niet dit is vernietigd het zigzelf
        DontDestroyOnLoad(transform.gameObject);

        if (gm == null)
        {
            gm = this;
        }

        else if (gm != this)
        {
            Destroy(gameObject);
        }


       
    }
	
	
	void Update ()
    {
		// spawned enmy door link met ander script
        if(Input.GetButtonDown("Spawn"))
        {
            spawnScript.Spawner();
        }

    }

    
    public void SceneManager ()
    {

    }

    public void OnLevelWasLoaded()
    {
        GameObject enemySpawner = GameObject.FindWithTag("EnemySpawner");
        spawnScript = enemySpawner.GetComponent<EnemySpawner>();
    }
}
