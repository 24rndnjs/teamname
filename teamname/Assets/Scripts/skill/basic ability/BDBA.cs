using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BDBA : Skill
{
    private Database playerData;
    ButtonManager skillcount;
    int skillpoint = 1;

    void Update()
    {
        skillcount = GameObject.FindObjectOfType<ButtonManager>();
        if (skillcount.buttoncount[7] == skillpoint)
        {
             playerData.DmgMultiplier += 0.5f;
        }
    }
    
}
