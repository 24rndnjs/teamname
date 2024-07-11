using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : Skill
{
    private Database playerData;
    ButtonManager skillcount;
    int skillpoint = 1;

    void Update()
    {
        skillcount = GameObject.FindObjectOfType<ButtonManager>();
        if (skillcount.buttoncount[4] == skillpoint)
        {
            LvUP();
            ++skillpoint;
        }
    }
    private void LvUP()
    {
        Lv++;
        playerData.health = Rate;
        if (Lv == MaxLv)
        {
            IsMaxLv = true;
        }
    }
}
