using UnityEngine;
using System.Collections;

public class Addforce : MonoBehaviour {

	public Vector3 direction;
	public Rigidbody ball;
    public int force;

	public void OnCollisionEnter(Collision collision)
	{
        direction = collision.contacts[0].point;
        ball.AddForce(direction * force);
	}
}
