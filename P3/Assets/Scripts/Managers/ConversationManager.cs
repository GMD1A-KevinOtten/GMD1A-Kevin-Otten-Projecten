using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationManager : MonoBehaviour {

    public ObjectiveManager objectiveManager;
    public Conversation currentNpcConvScript;
    public UIManager ui;
    public PlayerManager pm;
    public int indexText = 0;
    public int indexLeft = 0;
    public int indexRight = 1;

    public void CurrentConversationInput(Conversation conv)
    {
        currentNpcConvScript = conv;
        FirstConvPart();
        ui.NameText(conv.name);
    }

    public void FirstConvPart()
    {
        ui.ConvText(currentNpcConvScript.conv[0]);
        ui.LeftButton(currentNpcConvScript.ant[0]);
        ui.RightButton(currentNpcConvScript.ant[1]);
    }

    public void NextConvLeftButton()
    {
        if (indexLeft != currentNpcConvScript.ant.Count - 2)
        {
            indexText += 1;
            indexLeft += 2;
            indexRight += 2;
            ui.LeftButton(currentNpcConvScript.ant[indexLeft]);
            ui.RightButton(currentNpcConvScript.ant[indexRight]);
            ui.ConvText(currentNpcConvScript.conv[indexText]);
        }

        else
        {
            objectiveManager.ObjectiveUpdate(currentNpcConvScript.objective);
            objectiveManager.ObjectiveTick(currentNpcConvScript.objectiveIndex);
            Goodby();
        }  
    }

    public void Goodby()
    {
        int index = currentNpcConvScript.conv.Count - 1;
        ui.ConvText(currentNpcConvScript.conv[index]);
        StartCoroutine(CloseConversation(3));
    }

    IEnumerator CloseConversation(float time)
    {
        pm.CursorOnOf();
        yield return new WaitForSeconds(time);
        pm.RevertConversationSettings();
        indexText = 0;
        indexLeft = 0;
        indexRight = 1;
    }
}
