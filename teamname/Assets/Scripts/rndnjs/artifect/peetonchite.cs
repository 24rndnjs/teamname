using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peetonchite : MonoBehaviour
{
    public Database player;
    public GameObject game;
    private int attackCount = 0; // 적 공격 횟수 카운터
    private const int maxStacks = 6; // 최대 중첩 횟수
    private const float speedIncreasePercentage = 1.1f; // 이동 속도 증가 비율 (10%)

    void Start()
    {
        player.MoveSpeed = player.moveSpeed; // 플레이어의 기본 이동 속도를 초기화
    }

    void Update()
    {
        // 게임 로직 업데이트 (필요 시 추가)
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // 적 오브젝트 파괴
            IncreaseMoveSpeed(); // 이동 속도 증가
        }
    }

    void IncreaseMoveSpeed()
    {
        if (attackCount < maxStacks)
        {
            player.MoveSpeed *= speedIncreasePercentage; // 이동 속도 10% 증가
            attackCount++; // 공격 횟수 증가
            Debug.Log("Player MoveSpeed increased to: " + player.MoveSpeed); // 디버그 로그로 이동 속도 확인
        }
    }
}
