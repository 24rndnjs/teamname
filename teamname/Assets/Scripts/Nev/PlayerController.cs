using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 10;

    public Vector2 inputVec;
    Animator animator;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (animator == null)
        {
            Debug.LogWarning("Animator component is missing from the Player game object.");
        }

        if (spriteRenderer == null)
        {
            Debug.LogWarning("SpriteRenderer component is missing from the Player game object.");
        }
    }

    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(inputVec.x * speed * Time.deltaTime, inputVec.y * speed * Time.deltaTime, 0));

        // �ִϸ��̼� �Ķ���� ����
        if (animator != null)
        {
            bool isMoving = (inputVec.x != 0 || inputVec.y != 0);
            animator.SetBool("ismoving", isMoving);
        }

        // ��������Ʈ ������
        if (spriteRenderer != null)
        {
            if (inputVec.x > 0)
            {
                spriteRenderer.flipX = true;
            }
            else if (inputVec.x < 0)
            {
                spriteRenderer.flipX = false;
            }
        }
    }
}
