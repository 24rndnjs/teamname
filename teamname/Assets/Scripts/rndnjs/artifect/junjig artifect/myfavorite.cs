using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myfavorite : MonoBehaviour
{
    public GameObject player; // �÷��̾� �����ͺ��̽�
    public GameObject game; // ���� ������Ʈ
    public GameObject clonePrefab; // ��ȯ�� �н��� ������

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            // �÷��̾� ��ó�� �н� ��ȯ
            Vector3 spawnPosition = player.transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
            Instantiate(clonePrefab, spawnPosition, Quaternion.identity);

            // �������� �Ծ����Ƿ�, ���� ������Ʈ �ı�
            Destroy(game);
        }
    }
}
