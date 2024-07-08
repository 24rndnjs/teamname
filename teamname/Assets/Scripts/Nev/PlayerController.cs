using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 10;

    void Start()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(h * speed * Time.deltaTime, v * speed * Time.deltaTime, 0));
    }
}
