using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastWork : Skill
{
    private Database playerData;

    public void Select()
    {
        LvUP();
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
