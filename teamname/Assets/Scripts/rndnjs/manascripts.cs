using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI 관련 네임스페이스 추가

public class manascripts : MonoBehaviour
{
    public Slider manaSlider; // 마나 슬라이더
    public GameObject game;
    void Start()
    {
        // 초기 설정이 필요한 경우 이곳에 작성
    }

    void Update()
    {
        // 매 프레임마다 실행할 코드가 있다면 이곳에 작성
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // 슬라이더 값 10 증가
            if (manaSlider != null)
            {
                manaSlider.value += 10;
            }

            // 자신을 파괴
            Destroy(game);
        }
    }
}
