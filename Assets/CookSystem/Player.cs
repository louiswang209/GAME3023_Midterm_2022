using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public Dictionary<string, int> PlayerStat = new Dictionary<string, int>();

    //public TMP_Text Health_Amount;
    //public TMP_Text Mana_Amount;
    public TMP_Text Str_Amount;
    public TMP_Text Dex_Amount;
    public TMP_Text Int_Amount;
    public TMP_Text Def_Amount;
    public TMP_Text Sta_Amount;

    private void Start()
    {
        //PlayerStat.Add("Health", 5);
        //PlayerStat.Add("Mana", 5);
        PlayerStat.Add("strength", 10);
        PlayerStat.Add("dexterity", 10);
        PlayerStat.Add("intelligence", 10);
        PlayerStat.Add("defense", 10);
        PlayerStat.Add("stamina", 10);
    }

    private void Update()
    {
        //Health_Amount.SetText(PlayerStat["Health"].ToString());
        //Mana_Amount.SetText(PlayerStat["Mana"].ToString());
        Str_Amount.SetText(PlayerStat["strength"].ToString());
        Dex_Amount.SetText(PlayerStat["dexterity"].ToString());
        Int_Amount.SetText(PlayerStat["intelligence"].ToString());
        Def_Amount.SetText(PlayerStat["defense"].ToString());
        Sta_Amount.SetText(PlayerStat["stamina"].ToString());
    }

}
