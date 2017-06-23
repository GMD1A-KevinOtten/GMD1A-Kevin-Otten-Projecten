using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public enum Pannel

    {
        Main,
        Inventory
    }

    public Text interactionText;
    //Enum related var
    public static Pannel pannel;
    public InventoryScript invscript;
    public GameObject main;
    public GameObject inv;
    public UnityEngine.Sprite sword;
    public Text description;
    public Text statistics;

    //verandert pannel van de 1 naar de ander
    public void PannelOnOff()
    {
        if (pannel == Pannel.Main)
        {
            main.SetActive(false);
            inv.SetActive(true);
            pannel = Pannel.Inventory;
        }

        else if (pannel == Pannel.Inventory)
        {
            main.SetActive(true);
            inv.SetActive(false);
            pannel = Pannel.Main;
        }
    }

    //Main Pannel
    public void InteractionText(string interact)
    {
        interactionText.text = "" + interact;
    }

    //Inventory Pannel
    public void DescriptionTextUpdate(string descText)
    {
        description.text = descText;
    }

    public void StatsTextUpdate(string stats)
    {
        statistics.text = stats;
    }
}
