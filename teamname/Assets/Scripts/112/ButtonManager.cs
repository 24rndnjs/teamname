using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Skills; // ��ų ������ �迭: ���� ������Ʈ�� ����Ǿ�, �̵� �߿��� �ν��Ͻ��� �����մϴ�.
    public GameObject canvas; // ĵ���� ����: ��ư�� ��ġ�� ĵ���� ���� ������Ʈ.

    public int[] buttoncount = new int[21] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // ��ư Ŭ�� Ƚ���� �����ϴ� �迭.

    private void Awake()
    {
        List<int> chosenIndices = new List<int>(); // ���õ� �ε����� ������ ����Ʈ.
        int a = 1; // ��ư�� ��ġ�� �� ����� y �� ��ǥ.

        // �� ���� ��ư�� �����ϱ� ���� ����.
        for (int i = 0; i < 3; ++i)
        {
            int index;
            do
            {
                index = Random.Range(0, Skills.Length); // Skills �迭���� ���� �ε��� ����.
            }
            while (chosenIndices.Contains(index)); // �̹� ���õ� �ε����� �����ϰ� ���ο� �ε����� ����.

            chosenIndices.Add(index); // ���� ���õ� �ε����� ����Ʈ�� �߰�.

            GameObject btn = Instantiate(Skills[index], new Vector3(0, a, 0), Quaternion.identity); // ���õ� ��ų �������� �ν��Ͻ�ȭ.
            btn.transform.SetParent(canvas.transform); // ������ ��ư�� ĵ������ �ڽ����� ����.
            btn.transform.DOLocalMoveY(90, 0.7f).SetEase(Ease.InQuad).SetRelative(); // ��ư�� ��ġ �ִϸ��̼� ����.
            int buttonindex = index; // Ŭ�� �����ʿ� ����� �ε��� ���� ����.
            btn.GetComponent<Button>().onClick.AddListener(() => ButtonClick(buttonindex)); // Ŭ�� ������ �߰�.
            a -= 3; // ���� ��ư�� y �� ��ġ ����.
        }
    }

    public void ButtonClick(int buttonindex)
    {
        Debug.Log("Clicked"); // Ŭ�� �α� ���.
        OnClickSkillPerk(); // �߰� ��ų ȹ�� ó�� �Լ� ȣ��.
        ++buttoncount[buttonindex]; // �ش� ��ư�� Ŭ�� Ƚ�� ����.

        Button[] chooicebuttons = canvas.transform.GetComponentsInChildren<Button>(); // ĵ������ �ִ� ��� ��ư ������Ʈ�� ������.
        for (int i = 0; i < chooicebuttons.Length; ++i)
        {
            Destroy(chooicebuttons[i].gameObject); // ��� ��ư ����.
        }
    }

    public void OnClickSkillPerk()
    {
        Debug.Log("LVUP"); // ������ �α� ���.
    }
}
