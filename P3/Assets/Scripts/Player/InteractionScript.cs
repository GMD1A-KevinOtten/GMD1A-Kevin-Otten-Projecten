using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{

    RaycastHit npc;
    public PlayerManager pM;
    public UIManager uiManager;
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);

        if(Physics.Raycast(transform.position, transform.forward, out npc, 2f) && npc.collider.GetComponent<Conversation>() != null)
        {
            uiManager.InteractionText("Press E");

            if(Input.GetButtonDown("Interact"))
            {
                pM.SetConversationSettings(npc.collider.gameObject);
            }
        }

        else
        {
            uiManager.InteractionText("");
        }
    }

    
}
