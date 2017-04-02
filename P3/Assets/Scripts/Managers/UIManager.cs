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

    //Main Pannel Text
    public Text huidigeObjective;
    public Text popUpText;
    public Text interactionText;

    //Conversation Pannel Text
    public Text conversationText;
    public Text leftButton;
    public Text rightButton;

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
        
        else if(pannel == Pannel.Main)
        {
            main.SetActive(true);
            conv.SetActive(false);
        }
    }

    //Main Pannel
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

    //Conversation Pannel
    public void ConvText(string text)
    {
        conversationText.text = "" + text;
    }

    public void LeftButton(string lB)
    {
        leftButton.text = "" + lB;
    }

    public void RightButton(string rB)
    {
        rightButton.text = "" + rB;
    }
}
