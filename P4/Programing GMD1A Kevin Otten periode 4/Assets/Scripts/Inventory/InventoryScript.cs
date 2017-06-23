using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour {

    public List<ItemSlot> slots = new List<ItemSlot>();
    [Space(10)]
    public int invSpace = 10;
    public GameObject slotSprite;
    GameObject currentSlot;
    public Transform invPanel;
    public UIManager ui;
    public int InvIndex;

    void Start()
    {
        InvSpaceUpdate();
    }

    //stopt informatie in de itemslots en de sprites
    public void PutInInv(ItemHolder itemholder)
    {
        int index;
        for (index = 0; index < slots.Count; index++)
        {
            if (slots[index].item == null)
            {
                slots[index].item = itemholder.itemscript;
                slots[index].SpriteUpdate();
                break;
            }
        }
    }

    //Inv slots en slotsprites in spiewnen
    public void InvSpaceUpdate()
    {
        for (int i = 0; i < invSpace; i++)
        {
            slots.Add(new ItemSlot());
            slots[i].inv = this;
            slots[i].sprite = Instantiate(slotSprite, new Vector3(0, 0, 0), Quaternion.identity);
            currentSlot = slots[i].sprite;
            currentSlot.transform.SetParent(invPanel);
        }
    }

    //Extra stap op info door te stuuren
    public void SendDescriptionInfo(string descinfo)
    {
        ui.DescriptionTextUpdate(descinfo);
    }

    public void SendStatisticsInfo(string stats)
    {
        ui.StatsTextUpdate(stats);
    }
}
