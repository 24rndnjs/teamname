using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Oakleysunglasses : MonoBehaviour
{
    [SerializeField]
    Text timetext;//X

    private float maxtime = 13.0f;

    int skillpoint = 1;

    private Database playerData;
    ButtonManager skillcount;

    float time;

    public bool isplay = false;

    private void Start()
    {
    }
    void Update()
    {
        skillcount = GameObject.FindObjectOfType<ButtonManager>();

        if (skillcount.buttoncount[10] == skillpoint)
        {
            ++skillpoint;
            maxtime -= 1;
            if (skillpoint == 2)
                playerData.attack += 30;
            else
                playerData.attack += 5;
        }
        if (isplay == false && skillpoint > 1)
        {
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
