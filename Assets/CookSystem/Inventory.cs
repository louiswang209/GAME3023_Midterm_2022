using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemSlot> itemSlots = new List<ItemSlot>();
    public GameObject InventoryUI, AlchemyUI;

    [SerializeField]
    GameObject inventoryPanel;

    void Start()
    {
        InventoryUI.SetActive(true);
        AlchemyUI.SetActive(false);
        itemSlots = new List<ItemSlot>(inventoryPanel.transform.GetComponentsInChildren<ItemSlot>());
    }
}
