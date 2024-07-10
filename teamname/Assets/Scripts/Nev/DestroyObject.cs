using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public int destroySecond = 0;


    void Start()
    {
        Destroy(gameObject, destroySecond);
    }
}
