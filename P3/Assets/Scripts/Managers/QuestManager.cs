using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour {

    public UIManager ui;
    public static string currentObjective;

    void Start()
    {
        QuestUpdate("Locate the apple merchant");
    }

    public void QuestUpdate(string objective)
    {
        currentObjective = objective;
        ui.QuestInsert(currentObjective);
    }
}
