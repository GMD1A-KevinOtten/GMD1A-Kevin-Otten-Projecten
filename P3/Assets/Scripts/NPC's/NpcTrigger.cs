using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NpcTrigger : MonoBehaviour
{
    public EventManager eventManagerScript;
    public int enter;
    public int exit;

    void OnTriggerEnter(Collider other)
    {
        if(enter >= 0)
        {
            eventManagerScript.TriggerInsert(this);
            eventManagerScript.EventEnter();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(exit >= 0)
        {
            eventManagerScript.TriggerInsert(this);
            eventManagerScript.EventExit();
        }
    } 
}
