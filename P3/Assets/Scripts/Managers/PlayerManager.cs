using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public MovementController movement;
    public ConversationManager cm;
    public GameObject mainCam;
    public GameObject cinCam;
    bool camara = true;

    public void SetConversationSettings(GameObject npc)
    {
        MovementOnOf();
        CursorOnOf();
        UIManager.pannel = UIManager.Pannel.Conversation;
        cm.CurrentConversationInput(npc.GetComponent<Conversation>());
    }

    public void RevertConversationSettings()
    {
        MovementOnOf();
        UIManager.pannel = UIManager.Pannel.Main;
    }

    public void MovementOnOf()
    {
        if (movement.enabled == true)
        {
            movement.enabled = false;
        }
        else
        {
            movement.enabled = true;
        }
    }

    public void CursorOnOf()
    {
        if(Cursor.lockState == CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void CamaraOnOf()
    {
        if(camara == true)
        {
            mainCam.SetActive(false);
            cinCam.SetActive(true);
            camara = false;
        }
        else
        {
            mainCam.SetActive(true);
            cinCam.SetActive(false);
            camara = true;
        }
    }
}
