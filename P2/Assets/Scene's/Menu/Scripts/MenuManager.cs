using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public void OnGameStart()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    
    //haalt het spel uit play mode als we in de editor zitten en in andere dingen ofterwijl de build dan stopt het spel
    public void OnGameClosed()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }
    
    //niet belangerijk gewoon een extra knopje om het beter uit te laaten zien maak er wel wat leuks van
    public void OnMEMESLoaded()
    {

    }
}
