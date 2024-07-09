using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SelectSkill : MonoBehaviour
{
    [SerializeField]
    public int num;
    void Start()
    {
        transform.DOLocalMoveY(num, 0.7f).SetEase(Ease.InQuad);
    }

    void Update()
    {

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