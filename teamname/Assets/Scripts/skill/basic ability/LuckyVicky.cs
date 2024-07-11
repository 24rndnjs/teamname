using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LuckyVicky : Skill
{
    private Database playerData;
    ButtonManager skillcount;
    int skillpoint = 1;

    void Update()
    {
        skillcount = GameObject.FindObjectOfType<ButtonManager>();
        if (skillcount.buttoncount[5] == skillpoint)
        {
            LvUP();
            ++skillpoint;
        }
    }

        private void LvUP()
        {
            Lv++;
            playerData.defense += Rate;
            if (Lv == MaxLv)
            {
                IsMaxLv = true;
            }
        }
    }

