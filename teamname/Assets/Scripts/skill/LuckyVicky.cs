using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class LuckyVicky : MonoBehaviour
{
    public Database lucky;
    float[] Defense = new float[5] { 1.05f, 3.15f, 6.3f, 10.5f, 15.75f };
    int i = 0;
    void Start()
    {

    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Mouse0)))
        {
            ++i;
            luckyvicky();
        }
    }
    public void luckyvicky()
    {
        lucky.defense = Defense[i];
    }

}
