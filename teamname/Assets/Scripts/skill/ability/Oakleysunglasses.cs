using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Oakleysunglasses : MonoBehaviour
{
    private float maxtime = 10.0f;

    float time;

    public bool isplay = false;

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
    void Update()
    {
        if (isplay == false)
        {
            Debug.Log("skill");
            StartTimer();
        }
    }
}
