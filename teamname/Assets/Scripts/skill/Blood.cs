using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour
{
    private Database playerData;

    [SerializeField]
    int maxLv = 5;
    int Lv = 0;
    float Rate = 0.2f;
    bool isMaxLv = false;


    public void LvUP()
    {
        Lv++;
        playerData.health = Rate;
        if (Lv == maxLv)
        {
            isMaxLv = true;
        }
    }
}
