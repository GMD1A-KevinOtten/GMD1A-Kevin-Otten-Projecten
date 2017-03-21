using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanceTest : MonoBehaviour
{

    public void OnTriggerEnter(Collider c)
    {
        GameManager.ChanceLevel(0);
        Cursor.lockState = CursorLockMode.None;
    }

}
