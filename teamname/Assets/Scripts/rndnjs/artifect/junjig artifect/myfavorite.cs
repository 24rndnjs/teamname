using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myfavorite : MonoBehaviour
{
    public GameObject player; // 플레이어 데이터베이스
    public GameObject game; // 현재 오브젝트
    public GameObject clonePrefab; // 소환할 분신의 프리팹

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            // 플레이어 근처에 분신 소환
            Vector3 spawnPosition = player.transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
            Instantiate(clonePrefab, spawnPosition, Quaternion.identity);

            // 아이템을 먹었으므로, 현재 오브젝트 파괴
            Destroy(game);
        }
    }
}
