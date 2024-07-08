using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class LuckyVicky : MonoBehaviour
{
    public Database lucky;
    float[] Defense = new float[5] { 1.05f, 2.1f, 3.15f, 4.2f, 5.25f };
    void Start()
    {

    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Mouse0)))
        {
            luckyvicky();
        }
    }
    public void luckyvicky()
    {
        lucky.defense *= 1.05f;
    }

}
