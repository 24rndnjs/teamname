using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class efficiency : Skill
{
    private Database playerData;
    ButtonManager skillcount;
    int skillpoint = 1;

    void Update()
    {
        skillcount = GameObject.FindObjectOfType<ButtonManager>();
        if (skillcount.buttoncount[6] == skillpoint)
        {
            LvUP();
            ++skillpoint;
        }
    }

    private void LvUP()
    {
        Lv++;
        playerData.CritChance += Rate * 2;
        playerData.CritDamage += Rate;
        if (Lv == MaxLv)
        {
            IsMaxLv = true;
        }
    }
}
