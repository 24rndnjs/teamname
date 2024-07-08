using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class efficiency : MonoBehaviour
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
        playerData.CritChance += Rate * 2;
        playerData.CritDamage += Rate;
        if (Lv == maxLv)
        {
            isMaxLv = true;
        }
    }
}
