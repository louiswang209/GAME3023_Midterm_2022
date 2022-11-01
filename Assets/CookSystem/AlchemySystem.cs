using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlchemySystem : MonoBehaviour
{
    public Button BlenderButton, MakePotionButton;
    public GameObject Inventory, Alchemy;

    [SerializeField]
    Recipes Recipe;

    [SerializeField, Tooltip("Item slots")]
    List<ItemSlot> InputSlots = new List<ItemSlot>();

    public ItemSlot OutputSlot;

    public void BlenderButtonClicked()
    {
        Inventory.SetActive(true);
        Alchemy.SetActive(true);
    }

    public void CraftButtonClicked()
    {
        for (int i = 0; i < Inventory.GetComponent<Inventory>().itemSlots.Count; i++)
        {
            if(Inventory.GetComponent<Inventory>().itemSlots[i].item == null)
            {
                Inventory.GetComponent<Inventory>().itemSlots[i].AddItemToSlot(Recipe.RecipeOutput, 1);
                Debug.Log("Item added to slot");
                break;
            }
        }
    }
}
