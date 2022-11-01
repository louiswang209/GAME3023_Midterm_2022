using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//Holds reference and count of items, manages their visibility in the Inventory panel
public class ItemSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Item item = null;
    public GameObject player;

    [SerializeField]
    private TMPro.TextMeshProUGUI descriptionText;
    [SerializeField]
    private TMPro.TextMeshProUGUI nameText;

    [SerializeField]
    private int count = 0;
    public int Count
    {
        get { return count; }
        set
        {
            count = value;
            UpdateGraphic();
        }
    }

    [SerializeField]
    Image itemIcon;

    [SerializeField]
    TextMeshProUGUI itemCountText;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        UpdateGraphic();
    }

    private void Update()
    {
        UpdateGraphic();
    }

    //Change Icon and count
    void UpdateGraphic()
    {
        if (count < 1)
        {
            item = null;
            itemIcon.gameObject.SetActive(false);
            itemCountText.gameObject.SetActive(false);
        }
        else
        {
            //set sprite to the one from the item
            itemIcon.sprite = item.icon;
            itemIcon.gameObject.SetActive(true);
            itemCountText.gameObject.SetActive(true);
            itemCountText.text = count.ToString();
        }
    }

    public void UseItemInSlot()
    {
        if (CanUseItem())
        {
            item.Use();
            foreach (var effect in item.ItemEffects)
            {
                if (player.GetComponent<Player>().PlayerStat.ContainsKey(effect.Stat))
                {
                    player.GetComponent<Player>().PlayerStat[effect.Stat] += effect.Amount;
                    Debug.Log("Item Effect: " + effect.EffectName + " was used. Player's " + effect.Stat + "was increased by " + effect.Amount);
                }
            }
            if (item.isConsumable)
            {
                Count--;
            }
        }
    }

    public void AddItemToSlot(Item craftedItem, int craftedCount)
    {
        if (SlotIsEmpty())
        {
            item = craftedItem;
            count = craftedCount;
        }
    }

    private bool CanUseItem()
    {
        return (item != null && count > 0);
    }

    private bool SlotIsEmpty()
    {
        return (item == null);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (item != null)
        {
            descriptionText.text = item.description;
            nameText.text = item.name;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(item != null)
        {
            descriptionText.text = "";
            nameText.text = "";
        }
    }
}
