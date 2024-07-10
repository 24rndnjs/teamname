using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slate : MonoBehaviour
{
    public Database player;
    public GameObject game;
    public AudioClip tickSound; // �� �Ҹ� ���� ȿ����
    private AudioSource audioSource;
    public junjigdatabase junjig;
    private bool isTriggered = false; // �浹 ó�� �÷���

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = tickSound;

        // 9�ʸ��� Tick �޼��� ȣ��
        InvokeRepeating("Tick", 9.0f, 9.0f);
    }

    void Tick()
    {
        // �� �Ҹ� ���
        audioSource.Play();

        // ��� ���� �̵� �ӵ� ����
        StartCoroutine(ReduceEnemySpeed());
    }

    IEnumerator ReduceEnemySpeed()
    {
        // ȭ�� ���� ��� ���� ã��
        enemy[] enemies = FindObjectsOfType<enemy>();

        // ���� �ӵ� ����
        Dictionary<enemy, float> originalSpeeds = new Dictionary<enemy, float>();

        foreach (enemy enemy in enemies)
        {
            if (enemy != null)
            {
                originalSpeeds[enemy] = enemy.enemydata.speed;
                enemy.enemydata.speed *= 0.1f; // �̵� �ӵ��� -90%�� ����
            }
        }

        // 2�� ���� ����
        yield return new WaitForSeconds(2);

        // ���� �ӵ��� ����
        foreach (KeyValuePair<enemy, float> entry in originalSpeeds)
        {
            if (entry.Key != null)
            {
                entry.Key.enemydata.speed = entry.Value;
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isTriggered)
        {
            isTriggered = true; // �÷��� ����
            junjig.film += 1;
            StartCoroutine(PlaySoundAndDestroy());
        }
    }

    IEnumerator PlaySoundAndDestroy()
    {
        // ����� ���
        audioSource.Play();

        // ����� Ŭ�� ���̸�ŭ ���
        yield return new WaitForSeconds(audioSource.clip.length);

        // ������Ʈ �ı�
        Destroy(game);
    }
}
