using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    // events die ik zou maken had ik liever in een instantsiations van scripts stoppen maar aangezien veel van unitys dingen niet bruikbaar zonder de kenis om die aan te roepen deed ik het voornu maar op deze manier(daarom zoveel bools).
    public GameObject eventCamara;
    public UIManager ui;
    public ObjectiveManager obj;
    public PlayerManager pm;
    public NpcTrigger currentTrigger;
    public GameObject target;
    public GameObject invisibleStopWall;
    public bool camaraMovement;
    public bool eventNPV2ExitDone;
    public bool firstContact = true;
    public bool firstGoodby = true;
    public Animator pa;
    public ParticleSystem ps;
    public AudioSource asm;
    public AudioClip expl;
    public AudioClip war;
    

    // movement van een camara in 1  van de events
    void Update()
    {
        if(camaraMovement == true)
        {
            eventCamara.transform.position = Vector3.MoveTowards(eventCamara.transform.position, target.transform.position, 10 * Time.deltaTime);
        }
    }

    // insert info van Trigger script op npc
    public void TriggerInsert(NpcTrigger trigger)
    {
        currentTrigger = trigger;
    }

    // event voor de enter van een trigger
    public void EventEnter()
    {
        if(currentTrigger.enter == 1)
        {
            if(firstContact == true)
            {
                StartCoroutine(popupTextNPC1Enter(2));
                firstContact = false;
            }
        }

        if(currentTrigger.enter == 2)
        {
            pm.SetConversationSettings(currentTrigger.gameObject);
        }
    }

    // event voor de exit van een trigger
    public void EventExit()
    {
        // NPC1
        if(currentTrigger.exit == 1)
        {
            if(firstGoodby == true)
            {
                StartCoroutine(popupTextNPC1Exit(2));
                firstGoodby = false;
            }
        }
        //NPC2
        if(currentTrigger.exit == 2 && obj.objectives[1] == true && eventNPV2ExitDone != true)
        {
            StartCoroutine(EventNPC2Exit(12));
        }
    }

    //coroutines voor NPC1 Trigger
    IEnumerator popupTextNPC1Enter(float i)
    {
            ui.PopUpTextInsert("Hey Over Here!");
            yield return new WaitForSeconds(i);
            ui.PopUpTextInsert("");
    }
    IEnumerator popupTextNPC1Exit(float i)
    {
            ui.PopUpTextInsert("ByBy");
            yield return new WaitForSeconds(i);
            ui.PopUpTextInsert("");
    }

    //coroutine voor NPC2 Trigger (activeerd Cutscene en kapt die af na (zie input van TriggerExit NPC2) bepaalde tijd en gaat terug naar first person vieuw)
    IEnumerator EventNPC2Exit(float i)
    {
        asm.clip = null;
        pa.SetBool("Walking", false);
        ui.MainPannelOffOnn();
        pm.MovementOnOf();
        pm.CamaraOnOf();
        camaraMovement = true;
        StartCoroutine(Explosion(9));
        yield return new WaitForSeconds(i);
        asm.clip = war;
        asm.Play();
        obj.ObjectiveUpdate("Escape the sity");
        ui.MainPannelOffOnn();
        camaraMovement = false;
        pm.CamaraOnOf();
        pm.MovementOnOf();
        eventNPV2ExitDone = true;
        invisibleStopWall.SetActive(false);
    }

    IEnumerator Explosion(float i)
    {
        yield return new WaitForSeconds(i);
        asm.loop = false;
        asm.clip = expl;
        asm.Play();
        print("ok");
        ps.Play();
    }
}

