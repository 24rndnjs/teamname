using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : Skill
{
    private Database playerData;


    public void Select()
    {
        LvUP();
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
