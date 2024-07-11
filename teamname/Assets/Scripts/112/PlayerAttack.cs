using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour
{
    public bool isplay = false; // 플레이어가 공격을 했는지 여부
    public Animator animator;
    public GameObject sword;
    private Collider2D swordCollider; // 검의 Collider2D
    private Renderer swordRenderer;
    public Database player;

    void Start()
    {
        animator = GetComponent<Animator>();
        swordRenderer = sword.GetComponent<Renderer>();
        swordCollider = sword.GetComponent<Collider2D>();
        swordRenderer.enabled = false; // 시작 시 검을 비활성화
        swordCollider.enabled = false; // 시작 시 검의 콜라이더 비활성화
    }

    void Update()
    {
        if (!isplay)
        {
            isplay = true; // 공격 플래그 설정
            StartCoroutine(PlayAttackAnimation());
        }
    }

    private IEnumerator PlayAttackAnimation()
    {
        animator.SetBool("attackstart", true);
        ActivateSword(); // 검 활성화
        yield return new WaitForSeconds(1f); // 1초 동안 애니메이션 재생
        animator.SetBool("attackstart", false);
        DeactivateSword(); // 검 비활성화

        yield return StartCoroutine(CoolTime()); // 5초 쿨타임
    }

    private IEnumerator CoolTime()
    {
        yield return new WaitForSeconds(5f);
        isplay = false; // 다시 공격할 수 있도록 설정
        Debug.Log("Cooldown finished");
    }

    // 애니메이션 이벤트로 호출될 메서드
    public void ActivateSword()
    {
        swordRenderer.enabled = true;
        swordCollider.enabled = true; // 검의 콜라이더 활성화
    }

    // 애니메이션 이벤트로 호출될 메서드
    public void DeactivateSword()
    {
        swordRenderer.enabled = false;
        swordCollider.enabled = false; // 검의 콜라이더 비활성화
    }
}
