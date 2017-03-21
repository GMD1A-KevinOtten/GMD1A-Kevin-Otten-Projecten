using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

	
    public void PlayButton()
    {
        GameManager.ChanceLevel(1);
    }
	
    public void OptionsButton()
    {

    }

    public void StopButton()
    {
        GameManager.QuitGame();
    }
}
