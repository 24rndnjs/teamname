using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastWork : MonoBehaviour
{
    private Database playerData;

    [SerializeField]
    int maxLv = 5;
    int Lv = 0;
    float Rate = 0.1f;
    bool isMaxLv = false;

    public void Select()
    {
        LvUP();
    }

    private void LvUP()
    {
        Lv++;
        playerData.attackSpeed += Rate;
        if (Lv == maxLv)
        {
            isMaxLv = true;
        }
    }
}
