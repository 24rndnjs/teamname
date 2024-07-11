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
        if (!isplay)
        {
            isplay = true;
            StartCoroutine(PlayAttackAnimation());
        }
    }

    private IEnumerator PlayAttackAnimation()
    {
        animator.SetBool("attackstart", true);
        yield return new WaitForSeconds(1f); // 1�� ���� �ִϸ��̼� ���
        animator.SetBool("attackstart", false);
        yield return StartCoroutine(CoolTime()); // 5�� ��Ÿ��
    }

    private IEnumerator CoolTime()
    {
        yield return new WaitForSeconds(5f);
        isplay = false;
        Debug.Log("Cooldown finished");
    }
}
