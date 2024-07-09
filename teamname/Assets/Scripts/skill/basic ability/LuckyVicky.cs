using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class LuckyVicky : Skill
{
    private Database playerData;


    public void Select()
    {
        LvUP();
    }

    private void LvUP()
    {
        Lv++;
        playerData.defense += Rate;
        if (Lv == MaxLv)
        {
            IsMaxLv = true;
        }
    }
}
