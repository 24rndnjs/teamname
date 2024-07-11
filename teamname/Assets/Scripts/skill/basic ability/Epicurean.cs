using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Epicurean : Skill
{
    private Database playerData;
    ButtonManager skillcount;
    int skillpoint = 1;

    void Update()
    {
        skillcount = GameObject.FindObjectOfType<ButtonManager>();
        if (skillcount.buttoncount[8] == skillpoint)
        {
          playerData.Vamp += 0.1f;
        }
    }

    
}
