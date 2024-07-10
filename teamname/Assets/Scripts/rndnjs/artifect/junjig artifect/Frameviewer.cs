using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frameviewer : MonoBehaviour
{
    public Database player;
    public GameObject game;
    private int enemyCount = 0; // 적의 수를 저장하는 변수

    void Start()
    {
        // 초기화 필요 시 추가
    }

    void Update()
    {
        // 필요 시 추가
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            IncreaseAttackSpeed();
            Invoke("ResetAttackSpeed", 3f); // 3초 후에 공격 속도를 원래대로 복구
            Destroy(game); // 효과 적용 후 오브젝트 파괴
        }
    }

    void IncreaseAttackSpeed()
    {
        // 화면 내의 모든 적을 찾음
        enemy[] enemies = FindObjectsOfType<enemy>();

        // 적의 수만큼 플레이어의 공격 속도 증가
        enemyCount = enemies.Length;
        player.attackSpeed += enemyCount;

        Debug.Log("Player attack speed increased by: " + enemyCount);
        Debug.Log("New player attack speed: " + player.attackSpeed);
    }

    void ResetAttackSpeed()
    {
        // 원래 공격 속도로 복구
        player.attackSpeed -= enemyCount;

       
        enemyCount = 0; // 카운터 초기화
    }
}
