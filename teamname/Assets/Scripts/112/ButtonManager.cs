using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Skills; // 스킬 프리팹 배열
    public GameObject s; // 버튼들이 추가될 부모 오브젝트

    private void Awake()
    {
        List<int> chosenIndices = new List<int>(); // 선택된 인덱스를 저장할 리스트
        int a = 3;

        for (int i = 0; i < 3; ++i)
        {
            int index;
            do
            {
                index = Random.Range(0, Skills.Length);
            } while (chosenIndices.Contains(index)); // 중복되지 않는 인덱스를 찾을 때까지 반복

            chosenIndices.Add(index); // 선택된 인덱스를 리스트에 추가

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
