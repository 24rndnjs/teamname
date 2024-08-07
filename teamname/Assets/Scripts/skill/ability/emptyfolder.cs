using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emptyfolder : MonoBehaviour
{
    private float maxtime = 21f;

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

        if (skillcount.buttoncount[12] == skillpoint)
        {
            ++skillpoint;
            maxtime -= 1;
            if (skillpoint == 2)
                playerData.health += 10;
            else
                playerData.health += 5;
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
            yield return new WaitForSeconds(0.1f);
        }
        time = maxtime;
        isplay = false;
    }
}
