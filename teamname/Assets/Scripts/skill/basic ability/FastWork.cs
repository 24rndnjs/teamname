using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastWork : Skill
{
    private Database playerData;
    ButtonManager skillcount;
    int skillpoint = 1;

    void Update()
    {
        skillcount = GameObject.FindObjectOfType<ButtonManager>();
        if (skillcount.buttoncount[0] == skillpoint)
        {
            LvUP();
            ++skillpoint;
        }
    }
    private void LvUP()
    {
        Lv++;
        playerData.attackSpeed += Rate;
        if (Lv == MaxLv)
        {
            IsMaxLv = true;
        }
    }
}
