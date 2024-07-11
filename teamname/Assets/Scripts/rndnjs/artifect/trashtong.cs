using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashtong : MonoBehaviour
{
    public Database player;
    public GameObject game;
    private int killCount = 0; // �� óġ Ƚ�� ī����

    void Start()
    {
        player.DEF = player.defense;
    }

    void Update()
    {
        // ���� ���� ������Ʈ (�ʿ� �� �߰�)
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject); // �� ������Ʈ �ı�
            killCount++; // �� óġ Ƚ�� ����
            CheckKillCount(); // óġ Ƚ�� üũ�Ͽ� ���� ����
        }
    }

    void CheckKillCount()
    {
        if (killCount >= 10)
        {
            player.DEF *= 1.01f; // ���� 1% ����
            killCount = 0; // ī���� �ʱ�ȭ
            Debug.Log("Player DEF increased to: " + player.DEF); // ����� �α׷� ���� Ȯ��
        }
    }
}
