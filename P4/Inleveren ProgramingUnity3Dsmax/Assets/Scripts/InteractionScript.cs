using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{

    RaycastHit item;
    public PlayerManager pm;

    //het interaction systeem dat de info van het object met een conversation scripts doorstuurt naar de playermanager
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);

        if(Physics.Raycast(transform.position, transform.forward, out item, 2f) && item.collider.GetComponent<Item>() != null)
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
