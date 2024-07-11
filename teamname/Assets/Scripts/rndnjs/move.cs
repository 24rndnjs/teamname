using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public RectTransform creditsPanel;  // 크레딧 패널의 RectTransform
    public float speed = 50f;  // 크레딧이 올라가는 속도
    public float offset = 100f; // 시작 위치의 오프셋 (필요에 따라 조정)

    private float startY;
    private float endY;

    void Start()
    {
        // 시작 위치와 끝 위치를 설정합니다.
        startY = -creditsPanel.rect.height - offset;  // 시작 위치는 화면 하단보다 약간 아래로 설정
        endY = Screen.height + creditsPanel.rect.height;  // 끝 위치는 화면 상단보다 약간 위로 설정

        // 크레딧 패널의 초기 위치를 설정합니다.
        creditsPanel.anchoredPosition = new Vector2(0, startY);
    }

    void Update()
    {
        // 크레딧 패널을 위로 이동시킵니다.
        creditsPanel.anchoredPosition += new Vector2(0, speed * Time.deltaTime);

        // 크레딧 패널이 화면 상단을 지나가면 다시 초기 위치로 설정합니다.
        if (creditsPanel.anchoredPosition.y >= endY)
        {
            creditsPanel.anchoredPosition = new Vector2(0, startY);
        }
    }
}
