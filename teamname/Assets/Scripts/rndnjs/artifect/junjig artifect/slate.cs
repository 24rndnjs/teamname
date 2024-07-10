using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slate : MonoBehaviour
{
    public Database player;
    public GameObject game;
    public AudioClip tickSound; // 딱 소리 나는 효과음
    private AudioSource audioSource;
    public junjigdatabase junjig;
    private bool isTriggered = false; // 충돌 처리 플래그

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = tickSound;

        // 9초마다 Tick 메서드 호출
        InvokeRepeating("Tick", 9.0f, 9.0f);
    }

    void Tick()
    {
        // 딱 소리 재생
        audioSource.Play();

        // 모든 적의 이동 속도 감소
        StartCoroutine(ReduceEnemySpeed());
    }

    IEnumerator ReduceEnemySpeed()
    {
        // 화면 내의 모든 적을 찾음
        enemy[] enemies = FindObjectsOfType<enemy>();

        // 원래 속도 저장
        Dictionary<enemy, float> originalSpeeds = new Dictionary<enemy, float>();

        foreach (enemy enemy in enemies)
        {
            if (enemy != null)
            {
                originalSpeeds[enemy] = enemy.enemydata.speed;
                enemy.enemydata.speed *= 0.1f; // 이동 속도를 -90%로 줄임
            }
        }

        // 2초 동안 지속
        yield return new WaitForSeconds(2);

        // 원래 속도로 복구
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
            isTriggered = true; // 플래그 설정
            junjig.film += 1;
            StartCoroutine(PlaySoundAndDestroy());
        }
    }

    IEnumerator PlaySoundAndDestroy()
    {
        // 오디오 재생
        audioSource.Play();

        // 오디오 클립 길이만큼 대기
        yield return new WaitForSeconds(audioSource.clip.length);

        // 오브젝트 파괴
        Destroy(game);
    }
}
