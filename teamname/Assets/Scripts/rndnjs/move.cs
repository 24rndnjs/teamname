using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public RectTransform creditsPanel;  // ũ���� �г��� RectTransform
    public float speed = 50f;  // ũ������ �ö󰡴� �ӵ�
    public float offset = 100f; // ���� ��ġ�� ������ (�ʿ信 ���� ����)

    private float startY;
    private float endY;

    void Start()
    {
        // ���� ��ġ�� �� ��ġ�� �����մϴ�.
        startY = -creditsPanel.rect.height - offset;  // ���� ��ġ�� ȭ�� �ϴܺ��� �ణ �Ʒ��� ����
        endY = Screen.height + creditsPanel.rect.height;  // �� ��ġ�� ȭ�� ��ܺ��� �ణ ���� ����

        // ũ���� �г��� �ʱ� ��ġ�� �����մϴ�.
        creditsPanel.anchoredPosition = new Vector2(0, startY);
    }

    void Update()
    {
        // ũ���� �г��� ���� �̵���ŵ�ϴ�.
        creditsPanel.anchoredPosition += new Vector2(0, speed * Time.deltaTime);

        // ũ���� �г��� ȭ�� ����� �������� �ٽ� �ʱ� ��ġ�� �����մϴ�.
        if (creditsPanel.anchoredPosition.y >= endY)
        {
            creditsPanel.anchoredPosition = new Vector2(0, startY);
        }
    }
}
