using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainSpin : Skill
{
    private Database playerData;
    ButtonManager skillcount;
    int skillpoint = 1;

    void Update()
    {
        skillcount = GameObject.FindObjectOfType<ButtonManager>();
        if (skillcount.buttoncount[1] == skillpoint)
        {
            LvUP();
            ++skillpoint;
        }
    }

    private void LvUP()
    {
        Lv++;
        playerData.attack += Rate;
        if (Lv == MaxLv)
        {
            IsMaxLv = true;
        }
    }
}
