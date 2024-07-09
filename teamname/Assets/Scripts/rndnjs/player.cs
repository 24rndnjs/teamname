using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5.0f; // 플레이어 이동 속도
    public Database playera;
    // Start is called before the first frame update
    void Start()
    {
        float currentHp = playera.HP;
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal axis 입력 값 가져오기
        float move = Input.GetAxis("Horizontal");

        // 플레이어 위치 업데이트
        transform.position += new Vector3(move * speed * Time.deltaTime, 0, 0);
    }
}
