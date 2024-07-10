using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject player; // �÷��̾� ������Ʈ
    public GameObject[] monsters; // ��ȯ�� ���� ������ �迭
    public float spawnRadiusX = 50f; // X�� ��ȯ ����
    public float spawnRadiusY = 50f; // Y�� ��ȯ ����
    public float spawnInterval = 5f; // ��ȯ ����

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player object is not assigned in the MonsterSpawner script.");
            return;
        }

        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters()
    {
        while (true)
        {
            // �÷��̾� �ֺ� ���� ��ġ ����
            Vector3 spawnPosition = GetRandomSpawnPosition();

            // ���� ���� ����
            GameObject monsterToSpawn = monsters[Random.Range(0, monsters.Length)];

            // ���� ��ȯ
            Instantiate(monsterToSpawn, spawnPosition, Quaternion.identity);

            // ��ȯ ���� ���
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        float randomX = Random.Range(-spawnRadiusX, spawnRadiusX);
        float randomY = Random.Range(-spawnRadiusY, spawnRadiusY);
        return new Vector3(player.transform.position.x + randomX, player.transform.position.y + randomY, 0);
    }
}
