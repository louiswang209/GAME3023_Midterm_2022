using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item Effect", menuName = "Items/New Effect")]
public class ItemEffects : ScriptableObject
{
    
    public string EffectName = "";

    [Tooltip("Stats effected")]
    public string Stat = "";

    [SerializeField, Tooltip("Amount")]
    public int Amount = 0;

}
