using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTasking : Skill
{

    private Database playerData;
    ButtonManager skillcount;
    int skillpoint = 1;

    void Update()
    {
        skillcount = GameObject.FindObjectOfType<ButtonManager>();
        if (skillcount.buttoncount[2] == skillpoint)
        {
            playerData.attack += 0.75f;
            playerData.attackSpeed += 0.75f;
        }
    }
}
