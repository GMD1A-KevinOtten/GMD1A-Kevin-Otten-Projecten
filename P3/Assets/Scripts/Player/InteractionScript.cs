using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{

    public MovementController movement;
    RaycastHit npc;
    public UIManager uiManager;

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);

        if (Physics.Raycast(transform.position, transform.forward, out npc, 2f) && npc.collider.tag == "NPC")
        {
            uiManager.InteractionText("Press E");

            if (Input.GetButtonDown("Interact"))
            {
                movement.enabled = false;
                Cursor.lockState = CursorLockMode.None;
                UIManager.pannel = UIManager.Pannel.Conversation;
            }
        }

        else
        {
            uiManager.InteractionText("");
        }


    }

}
