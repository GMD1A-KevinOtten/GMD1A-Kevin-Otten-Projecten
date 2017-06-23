using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{

    RaycastHit item;
    public PlayerManager pm;


    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);

        if(Physics.Raycast(transform.position, transform.forward, out item, 2f) && item.collider.tag == "Item")
        {
            pm.InteractionText("Press E To Pick Up");

            if(Input.GetButtonDown("Interact"))
            {
                pm.PickupItem(item.collider.gameObject);
                Destroy(item.collider.gameObject);
            }
        }
        else
        {
            pm.InteractionText("");
        }
    }
}
