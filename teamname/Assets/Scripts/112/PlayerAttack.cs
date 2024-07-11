using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour
{
    public bool isplay = false; // �÷��̾ ������ �ߴ��� ����
    public Animator animator;
    public GameObject sword;
    private Collider2D swordCollider; // ���� Collider2D
    private Renderer swordRenderer;
    public Database player;

    void Start()
    {
        animator = GetComponent<Animator>();
        swordRenderer = sword.GetComponent<Renderer>();
        swordCollider = sword.GetComponent<Collider2D>();
        swordRenderer.enabled = false; // ���� �� ���� ��Ȱ��ȭ
        swordCollider.enabled = false; // ���� �� ���� �ݶ��̴� ��Ȱ��ȭ
    }

    void Update()
    {
        if (!isplay)
        {
            isplay = true; // ���� �÷��� ����
            StartCoroutine(PlayAttackAnimation());
        }
    }

    private IEnumerator PlayAttackAnimation()
    {
        animator.SetBool("attackstart", true);
        ActivateSword(); // �� Ȱ��ȭ
        yield return new WaitForSeconds(1f); // 1�� ���� �ִϸ��̼� ���
        animator.SetBool("attackstart", false);
        DeactivateSword(); // �� ��Ȱ��ȭ

        yield return StartCoroutine(CoolTime()); // 5�� ��Ÿ��
    }

    private IEnumerator CoolTime()
    {
        yield return new WaitForSeconds(5f);
        isplay = false; // �ٽ� ������ �� �ֵ��� ����
        Debug.Log("Cooldown finished");
    }

    // �ִϸ��̼� �̺�Ʈ�� ȣ��� �޼���
    public void ActivateSword()
    {
        swordRenderer.enabled = true;
        swordCollider.enabled = true; // ���� �ݶ��̴� Ȱ��ȭ
    }

    // �ִϸ��̼� �̺�Ʈ�� ȣ��� �޼���
    public void DeactivateSword()
    {
        swordRenderer.enabled = false;
        swordCollider.enabled = false; // ���� �ݶ��̴� ��Ȱ��ȭ
    }
}
