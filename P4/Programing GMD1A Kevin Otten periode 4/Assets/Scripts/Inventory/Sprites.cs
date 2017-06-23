using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sprites : MonoBehaviour
{
    public ItemSlot myItem;

    public void PointerEnter()
    {
        if (myItem.item != null)
        {
            myItem.DescriptionUpdate(myItem.item.description);
        }
    }

    public void PointerExit()
    {
        myItem.DescriptionUpdate("");
    }

    public void PointerDown()
    {
    }

    public void PointerUp()
    {
    }
}
