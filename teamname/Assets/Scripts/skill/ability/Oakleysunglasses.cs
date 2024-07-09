using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Oakleysunglasses : MonoBehaviour
{
    [SerializeField]
    Text timetext;

    [SerializeField]
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
            timetext.text = time.ToString("0.0");
            yield return new WaitForSeconds(0.1f);
        }
        timetext.text = "skill";
        time = maxtime;
        isplay = false;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
