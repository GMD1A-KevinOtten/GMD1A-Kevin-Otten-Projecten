using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public static Spawner sp;
    public GameObject enemyPrefab;
    public GameObject playerPrefab;
    public float random1;
    public float random2;
    public List<GameObject> enemys = new List<GameObject>();

    void Start()
    {
        // singelton maken zodat bij geval van meerdere scenes 1 spawner kan gebruikt worden
        DontDestroyOnLoad(transform.gameObject);

        if (sp == null)
        {
            sp = this;
        }

        else if (sp != this)
        {
            Destroy(gameObject);
        }

        // eeven aanroepen als placeholder omdat ik niet weet hoe ik een specifieke Scene moet OnLevelWasLoaded
        PlayerSpawner();
        // een enemy spawnen zodat de game niet meteen ijndicht
        EnemySpawner();
    }

    void Update()
    {
        // placeholder voor terug na menu naadat alle enemys dood zijn
        if(enemys.Count == 0)
        {
            print("no enemys");
            SceneManager.LoadScene(0);
        }
    }

    public void PlayerSpawner()
    {
        //spawned de player op een random positie in de map
        RandomNumber();
        transform.position = new Vector3(random1, 0, random2);
        Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }

    public void EnemySpawner()
    {
        //spawned een enemy op een random positie met een forloop
        for (int i = 0; i < 10; i++)
        {
            RandomNumber();
            transform.position = new Vector3(random1, 1.2f, random2);
            enemys.Add(Instantiate(enemyPrefab, transform.position, Quaternion.identity));
        }
    }

	

    public void RandomNumber()
    {
        random1 = Random.Range(0, 200);
        random2 = Random.Range(0, 200);
    }
}
