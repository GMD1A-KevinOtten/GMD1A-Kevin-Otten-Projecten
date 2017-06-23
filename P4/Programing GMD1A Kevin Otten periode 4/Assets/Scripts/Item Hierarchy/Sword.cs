using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Sword : Weapon
{
    public void AssingStats()
    {
        itemName = "Sword";
        price = 11;
        weight = 5;
        stack = 1;
        durability = 100;
        damage = 10;
        reach = 3;

        description = "Many poeple say that this sword has bin used by king arthur himself\nEveryone ellse knows its just a sword";

    }
}
