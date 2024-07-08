using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainSpin : MonoBehaviour
{
    private Database playerData;

    [SerializeField]
    int maxLv = 5;
    int Lv = 0;
    bool isMaxLv = false;
    float[] Rate = new float[6] { 1, 1.1f, 1.2f, 1.3f, 1.4f, 1.5f };

    public void Select()
    {
        LvUP();
    }

    private void LvUP()
    {
        Lv++;
        playerData.attack = playerData.ATK*Rate[Lv];
        if (Lv == maxLv)
        {
            isMaxLv = true;
        }
    }
}
