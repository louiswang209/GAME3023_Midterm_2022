using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Recipe/New Recipe")]
public class Recipes : ScriptableObject
{
    [SerializeField, Tooltip("Ingredients needed")]
    public List<Item> ItemInputs = new List<Item>();

    [SerializeField, Tooltip("Recipe name")]
    public Item RecipeOutput;
}
