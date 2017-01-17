using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public GameObject spawnPoint;
    public float random1;
    public float random2;
    public float random3;


    void Start()
    {
        RandomNumber();
        spawnPoint.transform.position = new Vector3(random1, 1.2f, random3);
    }

    void Update ()
    {
        Vector3 spawnPosition = spawnPoint.transform.position;

        if (Input.GetButtonDown("Spawn"))
        {
            RandomNumber();
            spawnPoint.transform.position = new Vector3(random1, 1.2f, random3);

            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

        }

	}

    public void RandomNumber()
    {
        random1 = Random.Range(0f, 200f);
        random2 = Random.Range(0f, 200f);
        random3 = Random.Range(0f, 200f);
    }
}
