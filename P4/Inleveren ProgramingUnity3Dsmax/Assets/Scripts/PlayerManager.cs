using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public UIManager ui;
    public bool invOn;
    public MovementController movement;
    public Inventory inv;

    void Update()
    {
        if(Input.GetButtonDown("InvBut"))
        {
            ui.PannelOnOff();
            MovementOnOf();
            CursorOnOf();
            invOn = false;
        }
    }

    public void PickupItem(GameObject item)
    {
        inv.PutInInv(item.GetComponent<Item>());
    }

    public void InteractionText(string interact)
    {
        ui.InteractionText(interact);
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
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
