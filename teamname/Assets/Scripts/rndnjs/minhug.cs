using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minhug : MonoBehaviour
{
    private Animator Minhug;

    void Start()
    {
        Minhug = GetComponent<Animator>();
        if (Minhug == null)
        {
            Debug.LogError("Animator component not found on " + gameObject.name);
        }
    }

    void FixedUpdate()
    {
        // FixedUpdate is called once per frame
        attack();
    }

    void attack()
    {
        // ���⿡ �߰����� ���� ������ �ʿ��ϴٸ� �߰��� �� �ֽ��ϴ�.
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger zone.");
            if (Minhug != null)
            {
                Minhug.SetBool("attack", true);
                Debug.Log("Attack set to true.");
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {   
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player exited trigger zone.");
            if (Minhug != null)
            {
                Minhug.SetBool("attack", false);
                Debug.Log("Attack set to false.");
            }
        }
    }
}
