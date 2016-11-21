using UnityEngine;
using System.Collections;

//niet gelukt omdat ik nadat ik de knoppen had gefixed er gewoon weg niet achter kwam

public class Flipper : MonoBehaviour
{
    public Quaternion originalRotationValue;
    public bool activateFlipper;
    public float timer = 0;
    public GameObject flipperPivot;
    public Rigidbody ball;

    void start()
    {
        originalRotationValue = transform.rotation;
    }

    void Update()
    {
        if (Input.GetButtonDown("RightShift"))
            {
            activateFlipper = true;
            }
       
        if (timer > 0.08f)
            {
            activateFlipper = false; 
            ball.AddForce(-10, 0, -3);
            }
    }

    void FixedUpdate()
    { 
        if (activateFlipper)
            {
            transform.RotateAround (transform.position, flipperPivot.transform.up, 800 * Time.deltaTime);
            timer = timer + Time.deltaTime;
             }
        if(activateFlipper == false)
            {   
            
            }

    }
}
