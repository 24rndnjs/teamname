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
    bool isMaxLv = false;
    float[] Rate = new float[6] { 1, 1.05f, 1.1f, 1.15f, 1.2f, 1.25f };

    public void Select()
    {
        LvUP();
    }

    private void LvUP()
    {
        Lv++;
        playerData.defense = playerData.DEF * Rate[Lv];
        if (Lv == maxLv)
        {
            isMaxLv = true;
        }
    }
}
