using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSkill : MonoBehaviour
{
    void Start()
    {

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
