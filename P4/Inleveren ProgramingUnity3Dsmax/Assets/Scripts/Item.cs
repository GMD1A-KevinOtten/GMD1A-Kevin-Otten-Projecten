using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Item{

    public enum Type
    {
        sword,
        shield,
        bow,
        arrow,
        misc,
        potion,
        food,
    }

    public Type type;
    public int enumType;
    public string itemName = "zwaard";
    public int price = 11;
    public float weight = 11;
    public GameObject obj;
    public Sprite imageItem;
    public int stack = 1;
    public Inventory inv;

    //sword
    public float damage = 10;
    public float durability = 10;
    public float reach;
}
