using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashtong : MonoBehaviour
{
    public Database player;
    public GameObject game;
    private int killCount = 0; // 적 처치 횟수 카운터

    void Start()
    {
        player.DEF = player.defense;
    }

    void Update()
    {
        // 게임 로직 업데이트 (필요 시 추가)
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject); // 적 오브젝트 파괴
            killCount++; // 적 처치 횟수 증가
            CheckKillCount(); // 처치 횟수 체크하여 방어력 증가
        }
    }

    void CheckKillCount()
    {
        if (killCount >= 10)
        {
            player.DEF *= 1.01f; // 방어력 1% 증가
            killCount = 0; // 카운터 초기화
            Debug.Log("Player DEF increased to: " + player.DEF); // 디버그 로그로 방어력 확인
        }
    }
}
