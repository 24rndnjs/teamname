using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnertartifect : MonoBehaviour
{
    public GameObject player; // �÷��̾� ������Ʈ
    public GameObject[] artifect; // ��ȯ�� ���� ������ �迭
    public float spawnRadiusX = 50f; // X�� ��ȯ ����
    public float spawnRadiusY = 50f; // Y�� ��ȯ ����
    public float spawnInterval = 25f; // ��ȯ ����

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player object is not assigned in the artifect script.");
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
            GameObject artifecttospawn = artifect[Random.Range(0, artifect.Length)];

            // ���� ��ȯ
            Instantiate(artifecttospawn, spawnPosition, Quaternion.identity);

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
