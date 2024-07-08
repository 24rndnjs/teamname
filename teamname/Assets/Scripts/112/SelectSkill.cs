using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSkill : MonoBehaviour
{
    public bool isTreegerMouse = false;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && isTreegerMouse)
        {
            Debug.Log("Clicked Perk");
            OnClickSkillPerk();
        }
    }

    public void OnClickSkillPerk()
    {
        Debug.Log("gogogogogogogogogo");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MousePointer"))
        {
            isTreegerMouse = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MousePointer"))
        {
            isTreegerMouse = false;
        }
    }
}
