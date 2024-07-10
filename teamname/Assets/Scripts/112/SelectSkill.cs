using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
public class SelectSkill : MonoBehaviour
{
    public Button[] buttons = new Button[3];
    public string[] buttoncheck = new string[21] { "skill 1", " skill 2", " skill 3", "skill 4", "skill 5", "skill 6", "skill 7", "skill 8", "skill 9", " skill 10", " skill 11", " skill 12", "skill 13", " skill 14", " skill 15", "skill 16", "skill 17", "skill 18", "skill 19", "skill 20", "skill 21" };
    public int[] buttoncount = new int[21] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
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
        string EventButtonName = EventSystem.current.currentSelectedGameObject.name;
        for (int i = 0; i < 21; ++i)
        {
            if (buttoncheck[i]==EventButtonName)
            {
                ++buttoncount[i];
            }
        }

        Destroy(button.gameObject);
    }
    public void OnClickSkillPerk()
    {
        Debug.Log("LVUP");
    }
}