using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager gm;

    void Start ()
    {
        DontDestroyOnLoad(transform.gameObject);

        if(gm == null)
        {
            gm = this;
        }

        else if(gm != this)
        {
            Destroy(gameObject);
        }
    }
	
    public static void ChanceLevel(int i)
    {
        SceneManager.LoadScene(i, LoadSceneMode.Single);
    }

    public static void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }
}
