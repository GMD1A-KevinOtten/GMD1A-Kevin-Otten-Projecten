using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public List<ItemSlot> slots = new List<ItemSlot>();
    public List<GameObject> sprite = new List<GameObject>();
    [Space(10)]
    public int invSpace = 5;
    public GameObject slotSprit;
    GameObject currentSlot;
    public Transform invPanel;
    public RectTransform y;
    public RectTransform x;

    void Start()
    {
        InvSpaceUpdate();
    }

    void Update()
    {

    }

    public void PutInInv(Item itemScript)
    {
        itemScript = new Item();
        if (slots[0].item == null)
        {
            slots[0].item = itemScript;
            slots[0].Insert();
        }
    }

    public void InvSpaceUpdate()
    {
        for (int i = 0; i < invSpace; i++)
        {
            slots.Add(new ItemSlot());
        }

        for (int i = 0; i < invSpace; i++)
        {
            currentSlot = Instantiate(slotSprit,new Vector3(0,0,0),Quaternion.identity);
            currentSlot.transform.SetParent(invPanel);
            //geef de positie aan waar die steeds update voor de volgende sprite
        }
    }
}
