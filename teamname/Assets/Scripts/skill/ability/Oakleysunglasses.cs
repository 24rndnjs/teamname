using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Oakleysunglasses : MonoBehaviour
{
    private float maxtime = 13.0f;
    int a = 1;
    ButtonManager skillcount;
    [SerializeField]
    Text timetext;//X

    float time;

    public bool isplay = false;

    private void Start()
    {
    }
    void Update()
    {
        skillcount = GameObject.FindObjectOfType<ButtonManager>();

        if (skillcount.buttoncount[0] == a)
        {
            Debug.Log("asdfasf");
            ++a;
            maxtime -= 1;
        }
        if (isplay == false && a > 1) 
        {
            Debug.Log("skill");
            StartTimer();
        }
    }


    public void StartTimer()
    {
        isplay = true;
        StartCoroutine(CoolTime());
    }

    public IEnumerator CoolTime()
    {
        while (time > 0.1f)
        {
            time -= 0.1f;
            timetext.text = time.ToString("0.0");//X
            yield return new WaitForSeconds(0.1f);
        }
        time = maxtime;
        isplay = false;
    }
}
