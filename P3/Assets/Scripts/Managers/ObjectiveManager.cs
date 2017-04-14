using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveManager : MonoBehaviour {

    public List<bool> objectives = new List<bool>();
    public UIManager ui;
    public static string currentObjective;

    //Initial Objective
    void Start()
    {
        ObjectiveUpdate("Locate the apple merchant");
    }

    //update Behaalde Objective
    public void ObjectiveTick(int index)
    {
        if(index != 0)
        {
            objectives[index] = true;
        }
    }

    //update Quest Text Ui
    public void ObjectiveUpdate(string objective)
    {
        if(string.IsNullOrEmpty(objective))
        {
            
        }
        else
        {
            ui.QuestInsert(objective);
        }
    }
}
