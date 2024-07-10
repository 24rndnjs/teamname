using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Skills; // 스킬 프리팹 배열: 게임 오브젝트로 저장되어, 이들 중에서 인스턴스를 생성합니다.
    public GameObject canvas; // 캔버스 선택: 버튼을 배치할 캔버스 게임 오브젝트.

    public int[] buttoncount = new int[21] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // 버튼 클릭 횟수를 추적하는 배열.

    private void Awake()
    {
        List<int> chosenIndices = new List<int>(); // 선택된 인덱스를 저장할 리스트.
        int a = 1; // 버튼을 배치할 때 사용할 y 축 좌표.

        // 세 개의 버튼을 생성하기 위한 루프.
        for (int i = 0; i < 3; ++i)
        {
            int index;
            do
            {
                index = Random.Range(0, Skills.Length); // Skills 배열에서 랜덤 인덱스 선택.
            }
            while (chosenIndices.Contains(index)); // 이미 선택된 인덱스는 제외하고 새로운 인덱스를 선택.

            chosenIndices.Add(index); // 새로 선택된 인덱스를 리스트에 추가.

            GameObject btn = Instantiate(Skills[index], new Vector3(0, a, 0), Quaternion.identity); // 선택된 스킬 프리팹을 인스턴스화.
            btn.transform.SetParent(canvas.transform); // 생성된 버튼을 캔버스의 자식으로 설정.
            btn.transform.DOLocalMoveY(90, 0.7f).SetEase(Ease.InQuad).SetRelative(); // 버튼에 위치 애니메이션 적용.
            int buttonindex = index; // 클릭 리스너에 사용할 인덱스 변수 저장.
            btn.GetComponent<Button>().onClick.AddListener(() => ButtonClick(buttonindex)); // 클릭 리스너 추가.
            a -= 3; // 다음 버튼의 y 축 위치 조정.
        }
    }

    public void ButtonClick(int buttonindex)
    {
        Debug.Log("Clicked"); // 클릭 로그 출력.
        OnClickSkillPerk(); // 추가 스킬 획득 처리 함수 호출.
        ++buttoncount[buttonindex]; // 해당 버튼의 클릭 횟수 증가.

        Button[] chooicebuttons = canvas.transform.GetComponentsInChildren<Button>(); // 캔버스에 있는 모든 버튼 컴포넌트를 가져옴.
        for (int i = 0; i < chooicebuttons.Length; ++i)
        {
            Destroy(chooicebuttons[i].gameObject); // 모든 버튼 제거.
        }
    }

    public void OnClickSkillPerk()
    {
        Debug.Log("LVUP"); // 레벨업 로그 출력.
    }
}
