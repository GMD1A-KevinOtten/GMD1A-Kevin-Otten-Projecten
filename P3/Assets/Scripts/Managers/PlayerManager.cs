using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public MovementController movement;
    public ConversationManager cm;
    public UIManager ui;
    public GameObject mainCam;
    public GameObject cinCam;
    bool camara = true;

    public void InteractionText(string interaction)
    {
        ui.InteractionText(interaction);
    }
    
    
    // set de settings voor een conversation triggerd door het interaction script of andere triggers
    public void SetConversationSettings(GameObject npc)
    {
        MovementOnOf();
        CursorOnOf();
        UIManager.pannel = UIManager.Pannel.Conversation;
        ui.PannelOnOff();
        cm.CurrentConversationInput(npc.GetComponent<Conversation>());
    }

    // set de settings vooor een conversation terug naar de normaale gameplay settings
    public void RevertConversationSettings()
    {
        MovementOnOf();
        UIManager.pannel = UIManager.Pannel.Main;
        ui.PannelOnOff();
    }

    // zet de movement uit als die voorheen aan is en andersom
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

    // zet de cursor unlocked als die locked is en andersom
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

    // switcht de camaras van de huidige main naar de cinematic camara en andersom
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
