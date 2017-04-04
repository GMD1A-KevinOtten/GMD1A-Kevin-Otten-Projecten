using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NpcTrigger : MonoBehaviour {

    public UIManager ui;

    IEnumerator OnTriggerEnter(Collider other)
    {
        ui.PopUpTextInsert("Hey Over Here!");
        yield return new WaitForSeconds(2);
        ui.PopUpTextInsert("");
    }

}
