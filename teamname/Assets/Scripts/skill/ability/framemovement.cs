using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class framemovement : MonoBehaviour
{
    private float maxtime = 10;

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

        if (skillcount.buttoncount[16] == skillpoint)
        {
            ++skillpoint;
            maxtime -= 1;
            if (skillpoint == 2)
                playerData.MoveSpeed += 10;
            else
                playerData.MoveSpeed += 1;
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
