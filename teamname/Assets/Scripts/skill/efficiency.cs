using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class efficiency : Skill
{
    private Database playerData;


    public void Select()
    {
        LvUP();
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
