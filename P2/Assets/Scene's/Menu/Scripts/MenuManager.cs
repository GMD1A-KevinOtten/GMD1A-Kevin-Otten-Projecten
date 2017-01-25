using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public void OnGameStart()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void OnGameClosed()
    {

    }

    public void OnMEMESLoaded()
    {

    }
}
