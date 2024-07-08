using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class hunger : MonoBehaviour
{
    private Database playerData;

    [SerializeField]
    int maxLv = 5;
    int Lv = 0;
    float Rate = 0.1f;
    bool isMaxLv = false;


    public void LvUP()
    {
        Lv++;
        playerData.moveSpeed += Rate;
        if (Lv == maxLv)
        {
            isMaxLv = true;
        }
    }
}
