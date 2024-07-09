using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Epicurean : Skill
{
    private Database playerData;


    public void Select()
    {
        playerData.Vamp += 0.1f;
    }
}
