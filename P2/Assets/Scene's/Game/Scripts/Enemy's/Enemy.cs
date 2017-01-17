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
        player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
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
