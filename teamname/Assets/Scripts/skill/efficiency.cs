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
    bool isMaxLv = false;
    float[] Rate = new float[5] { 4.2f, 12.6f, 25.2f, 42f, 63f };
    float[] Rate2 = new float[5] { 2.1f, 6.3f, 12.6f, 21f, 31.5f };

    public void Select()
    {
        LvUP();
    }

    private void LvUP()
    {
        Lv++;
        playerData.CritChance = Rate[Lv];
        playerData.CritDamage = Rate2[Lv];
        if (Lv == maxLv)
        {
            isMaxLv = true;
        }
    }
}
