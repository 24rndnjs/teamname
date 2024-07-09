using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTasking : Skill
{
    private Database playerData;


    public void Select()
    {
        playerData.attack += 0.75f;
        playerData.attackSpeed += 0.75f;
    }
}
