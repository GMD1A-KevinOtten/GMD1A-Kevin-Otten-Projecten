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

    //Main Pannel var
    public Text huidigeObjective;
    public Text popUpText;
    public Text interactionText;
    public bool mainPannel = true;

    //Conversation Pannel var
    public Text conversationText;
    public Text leftButton;
    public Text rightButton;
    public Text nameText;

    //Enum related var
    public static Pannel pannel;
    public GameObject main;
    public GameObject conv;

    public void PannelOnOff()
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

    public void MainPannelOffOnn()
    {
        if(mainPannel == true)
        {
            main.SetActive(false);
            mainPannel = false;
            print("eyy");
        }

        else
        {
            main.SetActive(true);
            mainPannel = true;
        }
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

    public void NameText(string name)
    {
        nameText.text = "" + name;
    }
}
