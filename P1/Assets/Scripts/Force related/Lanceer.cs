using UnityEngine;
using System.Collections;

public class Lanceer : MonoBehaviour {
   

    public float powerUp;
    public float powerUpMax = 1.39f;
    public bool pressed = false;
    public int maxForce = 1000;
    public Vector3 force = new Vector3(-1,0,0);
    public Rigidbody ball;
    public bool launchtrigger = false;

    void Update()
    {

        if (Input.GetButtonDown("Space"))
        
            {   
            // zorgt er voor dat de bool pressed aan gaat en de power up naar 0 reset.
                powerUp = 0;
                pressed = true;
            }

        if (Input.GetButtonUp("Space") && launchtrigger == true)
        {
            // zorgt er voor dat als de space button omhoog is en de trigger bool treu is dat de bal met force word afgeschoten.
            pressed = false;
            ball.AddForce(force * powerUp * maxForce);
        }

        if (pressed == true && powerUp < powerUpMax)
            {
            // zorgt er voor dat de powerup omhoog gaat in time.deltatime (ofterwijl met tijd passed en niet fps) als de max niet berijkt is.
                powerUp = powerUp + Time.deltaTime;
            }
        
    }

    void OnTriggerEnter()
    {
        // zorgt er voor dat als de bal in de colider aan het begin van de lanceerder zit hij afgeschoten kan worden.
        launchtrigger = true;
    }

    void OnTriggerExit()
    {
        //zorgt er voor dat als die niet in de trigger zit niet afgevuurt kan worden en zo constant spatie spammen te voorkomen
        launchtrigger = false;
    }
}
