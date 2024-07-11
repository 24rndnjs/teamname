using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class brokenkeycap : MonoBehaviour
{
    private float spinSpeed = 0.0f;

    int skillpoint = 1;

    private Database playerData;
    ButtonManager skillcount;


    public bool isplay = false;

    private void Start()
    {
    }
    void Update()
    {
        skillcount = GameObject.FindObjectOfType<ButtonManager>();

        if (skillcount.buttoncount[11] == skillpoint)
        {
            ++skillpoint;
            if (skillpoint == 2)
                playerData.attack += 15;
            else
                playerData.attack += 1;
            spinSpeed += 0.2f;
        }
    }
}
