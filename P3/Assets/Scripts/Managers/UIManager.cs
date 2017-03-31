using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public enum Pannel

    {
        Main,
        Conversation
    }

    public Text huidigeObjective;
    public Text popUpText;
    public Text interactionText;
    public static Pannel pannel;
    public GameObject main;
    public GameObject conv;

    void Update()
    {
        if(pannel == Pannel.Conversation)
        {
            main.SetActive(false);
            conv.SetActive(true);
        }
    }

    public void QuestInsert(string quest)
    {
        huidigeObjective.text = "" + quest;
    }
	
    public void PopUpTextInsert(string popup)
    {
        popUpText.text = "" + popup;
    }

    public void InteractionText(string interact)
    {
        interactionText.text = "" + interact;
    }
}
