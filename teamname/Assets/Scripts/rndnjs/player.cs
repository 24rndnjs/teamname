using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5.0f; // �÷��̾� �̵� �ӵ�
    public Database playera;
    // Start is called before the first frame update
    void Start()
    {
        float currentHp = playera.HP;
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal axis �Է� �� ��������
        float move = Input.GetAxis("Horizontal");

        // �÷��̾� ��ġ ������Ʈ
        transform.position += new Vector3(move * speed * Time.deltaTime, 0, 0);
    }
}
