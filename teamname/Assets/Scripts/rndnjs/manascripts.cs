using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI ���� ���ӽ����̽� �߰�

public class manascripts : MonoBehaviour
{
    public Slider manaSlider; // ���� �����̴�
    public GameObject game;
    void Start()
    {
        // �ʱ� ������ �ʿ��� ��� �̰��� �ۼ�
    }

    void Update()
    {
        // �� �����Ӹ��� ������ �ڵ尡 �ִٸ� �̰��� �ۼ�
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // �����̴� �� 10 ����
            if (manaSlider != null)
            {
                manaSlider.value += 10;
            }

            // �ڽ��� �ı�
            Destroy(game);
        }
    }
}
