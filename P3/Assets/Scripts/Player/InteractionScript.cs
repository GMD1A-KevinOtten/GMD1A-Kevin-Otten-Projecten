using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{

    RaycastHit npc;
    public PlayerManager pm;

    //het interaction systeem dat de info van het object met een conversation scripts doorstuurt naar de playermanager
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);

        if(Physics.Raycast(transform.position, transform.forward, out npc, 2f) && npc.collider.GetComponent<Conversation>() != null)
        {
            pm.InteractionText("Press E");

            if(Input.GetButtonDown("Interact"))
            {
                pm.SetConversationSettings(npc.collider.gameObject);
            }
        }

        else
        {
            pm.InteractionText("");
        }
    }

    
}
