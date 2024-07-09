using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class SelectSkill : MonoBehaviour
{
    public Button[] buttons = new Button[3];
    public Button button;

    private bool isChoose = false;

    public Text text;

    void Start()
    {
        button.onClick.AddListener(ButtonClick);
        transform.DOLocalMoveY(90, 0.7f).SetEase(Ease.InQuad).SetRelative();
    }
    
    public void ButtonClick()
    {
        Debug.Log("Clicked");
        OnClickSkillPerk();
        //Destroy(button.gameObject); 한번에 버튼 3개 지우기


    }
    public void OnClickSkillPerk()
    {
        Debug.Log("LVUP");

    }
}
