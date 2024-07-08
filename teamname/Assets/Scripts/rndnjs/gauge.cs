using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gauge : MonoBehaviour
{
    public float mana = 100;
    public float manamax = 100;
    public Slider sliderA;
    void Start()
    {
        
    }

    
    void Update()
    {
        sliderA.value = mana/manamax;
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "mana")
        {
            if (mana < manamax)
            {
                mana += 1;
                if (mana > manamax)
                {
                    mana = manamax;
                }
                sliderA.value = mana / manamax;
            }

        }
    }
    
}
