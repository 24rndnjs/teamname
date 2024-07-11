using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject player; // 플레이어 오브젝트
    public GameObject[] monsters; // 소환할 몬스터 프리팹 배열
    public GameObject specialMonster; // 10분 뒤에 소환할 특별 몬스터
    public float spawnRadiusX = 50f; // X축 소환 범위
    public float spawnRadiusY = 50f; // Y축 소환 범위
    public float spawnInterval = 2f; // 소환 간격

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player object is not assigned in the MonsterSpawner script.");
            return;
        }

        StartCoroutine(SpawnMonsters());
        StartCoroutine(SpawnSpecialMonster());
    }

    IEnumerator SpawnMonsters()
    {
        while (true)
        {
            // 플레이어 주변 랜덤 위치 생성
            Vector3 spawnPosition = GetRandomSpawnPosition();

            // 랜덤 몬스터 선택
            GameObject monsterToSpawn = monsters[Random.Range(0, monsters.Length)];

            // 몬스터 소환
            Instantiate(monsterToSpawn, spawnPosition, Quaternion.identity);

            // 소환 간격 대기
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    IEnumerator SpawnSpecialMonster()
    {
        // 10분 대기
        yield return new WaitForSeconds(600f); // 600초 = 10분

        // 플레이어 주변 랜덤 위치 생성
        Vector3 spawnPosition = GetRandomSpawnPosition();

        // 특별 몬스터 소환
        Instantiate(specialMonster, spawnPosition, Quaternion.identity);
    }

    Vector3 GetRandomSpawnPosition()
    {
        float randomX = Random.Range(-spawnRadiusX, spawnRadiusX);
        float randomY = Random.Range(-spawnRadiusY, spawnRadiusY);
        return new Vector3(player.transform.position.x + randomX, player.transform.position.y + randomY, 0);
    }
}
