using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myfavorite : MonoBehaviour
{
    public Database players;    
    public GameObject player; // �÷��̾� �����ͺ��̽�
    public GameObject game; // ���� ������Ʈ
    public GameObject clonePrefab; // ��ȯ�� �н��� ������
    public junjigdatabase junjig;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            junjig.ani += 1;
            junjig.game += 1;
            junjig.film += 1;
            junjig.comic += 1;
            // �÷��̾� ��ó�� �н� ��ȯ
            Vector3 spawnPosition = player.transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
            Instantiate(clonePrefab, spawnPosition, Quaternion.identity);

            // �������� �Ծ����Ƿ�, ���� ������Ʈ �ı�
            Destroy(game);
        }
    }
}
