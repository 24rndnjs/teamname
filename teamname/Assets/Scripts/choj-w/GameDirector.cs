using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public static GameDirector Instance;

    public int Exp;
    public int level;
    public float curExp;
    public float nextExp;

    Slider mySlider;

    private void Awake()
    {
        Instance = this;
        nextExp = 100f;
        mySlider = GetComponent<Slider>();
    }

    public void GetExp()
    {
        Exp++;
        curExp = Exp;
        if (curExp >= nextExp)
        {
            UpdateNextExp();
        }
        
    }

    private void UpdateNextExp()
    {
        nextExp *= 1.1f;
        nextExp = Mathf.Round(nextExp);
        nextExp = Mathf.Floor(nextExp);
    }

    void LateUpdate()
    {
        mySlider.value = curExp / nextExp;
    }
}
