using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float random1;
    public float random2;
   
    public void Spawner()
        {
            RandomNumber();
            transform.position = new Vector3(random1, 1.2f, random2);
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);

        }

	

    public void RandomNumber()
    {
        random1 = Random.Range(0, 200);
        random2 = Random.Range(0, 200);
    }
}
