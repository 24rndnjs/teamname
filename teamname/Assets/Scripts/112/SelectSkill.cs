using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class SelectSkill : MonoBehaviour
{
    [SerializeField]
    public int moveAmount;

    public Button button;

    private bool isChoose = false;

    public Text text;

    public void ColorChange()
    {
        ColorBlock colorBlock = button.colors;

        isChoose = !isChoose; 

        colorBlock.normalColor = isChoose ? Color.white : new Color(0f, 0f, 0f, 0f);
        colorBlock.selectedColor = isChoose ? Color.white : new Color(0f, 0f, 0f, 0f);

        button.colors = colorBlock;
    }


    void Start()
    {
       // transform.DOLocalMoveY(moveAmount, 0.7f).SetEase(Ease.InQuad).OnComplete(ColorChange);
    }

    public void ButtonClick()
    {
        Debug.Log("Clicked");
        OnClickSkillPerk();

    }

    public void OnClickSkillPerk()
    {
        Debug.Log("LVUP");
    }
}