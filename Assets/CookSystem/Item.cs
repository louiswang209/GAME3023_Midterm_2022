using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/New Item")]
public class Item : ScriptableObject
{
    public Sprite icon;
    public string description = "";
    public bool isConsumable = false;

    [SerializeField]
    public List<ItemEffects> ItemEffects = new List<ItemEffects>();

    public void Use()
    {
        Debug.Log("Used item: " + name + " - " + description);
    }
}
