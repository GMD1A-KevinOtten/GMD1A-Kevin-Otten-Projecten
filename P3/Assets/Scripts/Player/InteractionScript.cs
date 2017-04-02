using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour
{

    public MovementController movement;
    RaycastHit npc;
    public UIManager uiManager;
    public ConversationManager cm;

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);

        if (Physics.Raycast(transform.position, transform.forward, out npc, 2f) && npc.collider.GetComponent<Conversation>() != null)
        {
            uiManager.InteractionText("Press E");

            if (Input.GetButtonDown("Interact"))
            {
                SetConversationSettings();
            }
        }

        else
        {
            uiManager.InteractionText("");
        }
    }

    public void SetConversationSettings()
    {
        movement.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        UIManager.pannel = UIManager.Pannel.Conversation;
        cm.CurrentConversationInput(npc.collider.GetComponent<Conversation>());
    }

    public void RevertConversationSettings()
    {
        movement.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        UIManager.pannel = UIManager.Pannel.Main;
        cm.CurrentConversationInput(null);
        
    }
}
