using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Skills; // ��ų ������ �迭
    public GameObject s; // ��ư���� �߰��� �θ� ������Ʈ

    private void Awake()
    {
        List<int> chosenIndices = new List<int>(); // ���õ� �ε����� ������ ����Ʈ
        int a = 3;

        for (int i = 0; i < 3; ++i)
        {
            int index;
            do
            {
                index = Random.Range(0, Skills.Length);
            } while (chosenIndices.Contains(index)); // �ߺ����� �ʴ� �ε����� ã�� ������ �ݺ�

            chosenIndices.Add(index); // ���õ� �ε����� ����Ʈ�� �߰�

            GameObject btn = Instantiate(Skills[index], new Vector3(0, a, 0), Quaternion.identity);
            btn.transform.SetParent(s.transform);
            a -= 3;
        }
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
