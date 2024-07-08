using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class LuckyVicky : MonoBehaviour
{
    private Database playerData;

    [SerializeField]
    int maxLv = 5;
    int Lv = 0;
    float Rate = 0.05f;
    bool isMaxLv = false;

    public void Select()
    {
        LvUP();
    }

    private void LvUP()
    {
        Lv++;
        playerData.defense += Rate;
        if (Lv == maxLv)
        {
            isMaxLv = true;
        }
    }
}
