using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class hunger : Skill
{
    private Database playerData;
    ButtonManager skillcount;
    int skillpoint = 1;

    void Update()
    {
        skillcount = GameObject.FindObjectOfType<ButtonManager>();
        if (skillcount.buttoncount[3] == skillpoint)
        {
            LvUP();
            ++skillpoint;
        }
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
