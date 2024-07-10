using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failedcode : MonoBehaviour
{
    public Database player; // 플레이어 데이터베이스
    public GameObject game; // 현재 오브젝트
    public junjigdatabase junjig;
    private float originalAttack; // 원래 공격력 저장

    void Start()
    {
        // 원래 공격력 저장
        originalAttack = player.attack;
    }

    // 트리거 충돌 처리 메서드
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            junjig.game += 1;
            // 공격력 랜덤 증가 (1% ~ 99%)
            float randomIncreasePercentage = Random.Range(0.01f, 0.99f);
            player.attack = originalAttack * (1 + randomIncreasePercentage);

            // 충돌 시 적에게 데미지를 주는 로직 (필요 시 추가)

            // 원래 공격력으로 초기화 (여기서는 바로 초기화, 다음 공격 시 초기화를 원하면 로직 수정 필요)
            player.attack = originalAttack;
        }
    }
}
