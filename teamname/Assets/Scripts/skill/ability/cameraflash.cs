using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class cameraflash : MonoBehaviour
{
    private float maxtime = 15.5f;

    int skillpoint = 1;

    private Database playerData;//적 이속으로 바꾸기
    private EnenmyDatabase enemydata;//적 이속으로 바꾸기
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
            maxtime -= 0.5f;
            if (skillpoint == 2)
                playerData.attack += 10;
            else
                playerData.attack += 1;
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
