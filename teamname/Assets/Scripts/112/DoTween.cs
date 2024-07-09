using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DoTween : MonoBehaviour
{
    void Start()
    {
        transform.DOMove(Vector3.up, 5);
    }


    void Update()
    {
        
    }
}
