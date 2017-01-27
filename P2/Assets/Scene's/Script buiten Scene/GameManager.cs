using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Spawner spawnScript;
    public MenuManager menuScript;
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

        //assing het script zodat de game scene geladen kan worden
        GameObject menuManager = GameObject.FindWithTag("MenuManager");
        menuScript = menuManager.GetComponent<MenuManager>();
    }
	
	
	void Update ()
    {
		// spawned enmy door link met ander script
        if(Input.GetButtonDown("Spawn"))
        {
            spawnScript.EnemySpawner();
        }
    }

    // om scripts te refrence in verschilende scene's
    public void OnLevelWasLoaded()
    {
        //assing de spawner in game scene zodat enemy's kunnen spawnen met de game manager
        GameObject SpawnPoint = GameObject.FindWithTag("SpawnPoint");
        spawnScript = SpawnPoint.GetComponent<Spawner>();
        
        //assign het script zodat als we terug naar menu gaan het nogsteeds geconnect kan worden
        GameObject menuManager = GameObject.FindWithTag("MenuManager");
        menuScript = menuManager.GetComponent<MenuManager>();
    }

    //menu buttons
    public void StartButton()
    {
        menuScript.OnGameStart();
    }

    public void StopButton()
    {
        menuScript.OnGameClosed();
    }
}
