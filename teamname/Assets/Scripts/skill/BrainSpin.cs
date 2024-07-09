using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainSpin : Skill
{
    private Database playerData;


    public void Select()
    {
        LvUP();
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
