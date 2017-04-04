using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationManager : MonoBehaviour {

    public QuestManager questManager;
    public Conversation currentNpcConv;
    public UIManager ui;
    public InteractionScript inter;
    public int indexText = 0;
    public int indexLeft = 0;
    public int indexRight = 1;
    public string npcQuest;

    public void CurrentConversationInput(Conversation conv)
    {
        currentNpcConv = conv;
        FirstConvPart();

        if(conv.Quest != null)
        {
            npcQuest = conv.Quest;
        }
    }

    public void FirstConvPart()
    {
        ui.ConvText(currentNpcConv.conv[0]);
        ui.LeftButton(currentNpcConv.ant[0]);
        ui.RightButton(currentNpcConv.ant[1]);
    }

    public void NextConvLeftButton()
    {
        if (indexLeft != currentNpcConv.ant.Count - 2)
        {
            indexText += 1;
            indexLeft += 2;
            indexRight += 2;
            ui.LeftButton(currentNpcConv.ant[indexLeft]);
            ui.RightButton(currentNpcConv.ant[indexRight]);
            ui.ConvText(currentNpcConv.conv[indexText]);
        }

        else
        {
            Goodby();
            Quest();
        }  
    }

    public void Quest()
    {
        if(npcQuest != null)
        {
            questManager.QuestUpdate(npcQuest);
            npcQuest = null;
        }
    }

    public void Goodby()
    {
        int index = currentNpcConv.conv.Count - 1;
        ui.ConvText(currentNpcConv.conv[index]);
        StartCoroutine(CloseConversation(3));
    }

    IEnumerator CloseConversation(float time)
    {
        yield return new WaitForSeconds(time);
        inter.RevertConversationSettings();
        indexText = 0;
        indexLeft = 0;
        indexRight = 1;
    }
}
