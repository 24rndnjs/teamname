using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class hunger : MonoBehaviour
{
    public Database move;
    float[] arra = new float[5] { 1.1f, 1.2f, 1.3f, 1.4f, 1.5f };
    int a=0;s
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            a++;
            movespeed(a);
        }
        
        
    }

    public void movespeed(int i)
    {
        move.moveSpeed *= arra[i];

    }

}
