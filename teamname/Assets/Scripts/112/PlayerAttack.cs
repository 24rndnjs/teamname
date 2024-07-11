using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour
{
    public bool isplay = false;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (isplay == false)
        {
            animator.SetBool("attackstart", true);
            StartTimer();
        }

    }


    public void StartTimer()
    {
        StartCoroutine(CoolTime());
        isplay = true;

        animator.SetBool("attackstart", false);
        
      
        
    }

    public IEnumerator CoolTime()
    {
        
        yield return new WaitForSeconds(5f);
        isplay = false;
        Debug.Log("11");
    }

}
