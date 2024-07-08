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
    float[] Rate = new float[5] { 1.05f, 3.15f, 6.3f, 10.5f, 15.75f };

    public void Select()
    {
        LvUP();
    }

    private void LvUP()
    {
        Lv++;
        playerData.defense = Rate[Lv];
        if (Lv == maxLv)
        {
            isMaxLv = true;
        }
    }
}
