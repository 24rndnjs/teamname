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

    private void Awake()
    {
        Instance = this;
        nextExp = 100f;
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

    public class GaugeBar : MonoBehaviour
    {

        Slider mySlider;
        private float nextExp;
        public float curExp;

        void Awake()
        {
            mySlider = GetComponent<Slider>();
        }

        void LateUpdate()
        {
            mySlider.value = curExp / nextExp;
        }
    }
}
