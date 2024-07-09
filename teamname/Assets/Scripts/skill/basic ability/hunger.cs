using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class hunger : Skill
{
    private Database playerData;


    public void Select()
    {
        LvUP();
    }
    private void LvUP()
    {
        Lv++;
        playerData.moveSpeed += Rate;
        if (Lv == MaxLv)
        {
            IsMaxLv = true;
        }
    }
}
