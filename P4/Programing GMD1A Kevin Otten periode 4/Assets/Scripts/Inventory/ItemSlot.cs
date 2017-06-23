using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class ItemSlot{

    public Item item;

    public GameObject sprite;

    public int slotStack;
    public string slotItemName;
    public int slotPrice;
    public float slotWeight;
    public float slotDamage;
    public float slotDurability;

    public void SpriteUpdate()
    {
        sprite.GetComponent<Image>().sprite = item.imageItem;
        sprite.GetComponent<Sprites>().myItem = this;
    }
}
