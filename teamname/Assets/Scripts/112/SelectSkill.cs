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


        colorBlock.normalColor = isChoose ? new Color(1f, 1f, 1f, 1f) : Color.white;
        colorBlock.selectedColor = isChoose ? new Color(1f, 1f, 1f, 1f) : Color.white;

        text.text = "<color=black>skill</color>";
        button.colors = colorBlock;
    }

    void Start()
    {
        transform.DOLocalMoveY(moveAmount, 0.5f).SetEase(Ease.InQuad).OnComplete(ColorChange);
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