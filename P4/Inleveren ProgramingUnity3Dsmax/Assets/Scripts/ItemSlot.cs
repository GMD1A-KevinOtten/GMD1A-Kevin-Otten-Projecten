using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class ItemSlot{

    public Item item;
    public int slotStack;

    public string slotItemName;
    public int slotPrice;
    public float slotWeight;
    public float slotDamage;
    public float slotDurability;

    

    public void Insert()
    {
        slotItemName = item.itemName;
        slotPrice = item.price;
        slotWeight = item.weight;
        slotDamage = item.damage;
        slotDurability = item.durability;
        slotStack = item.stack;
    }

}
