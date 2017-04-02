using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationManager : MonoBehaviour {

    public Conversation currentNpcConv;
    public UIManager ui;
    public InteractionScript inter;

	
    public void CurrentConversationInput(Conversation conv)
    {
        currentNpcConv = conv;
        FirstConvPart();
    }

    public void FirstConvPart()
    {
        ui.ConvText(currentNpcConv.conv[0]);
        ui.LeftButton(currentNpcConv.ant[0]);
        ui.RightButton(currentNpcConv.ant[1]);
    }

    public void NextConvLeftButton()
    {
        int indexText =+ 1;
        int indexLeft =+ 2;
        int indexRight = 1 + 2;
        ui.LeftButton(currentNpcConv.ant[indexLeft]);
        ui.RightButton(currentNpcConv.ant[indexRight]);
        ui.ConvText(currentNpcConv.conv[indexText]);
    }

    public void Goodby()
    {
        ui.ConvText(currentNpcConv.conv[2]);
        StartCoroutine(CloseConversation(3));
    }

    IEnumerator CloseConversation(float time)
    {
        yield return new WaitForSeconds(time);
        inter.RevertConversationSettings();
    }
}
