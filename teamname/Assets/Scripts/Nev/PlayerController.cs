using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 10;

    public Vector2 inputVec;
    Animator animator;
    SpriteRenderer spriteRenderer;

    public EnenmyDatabase enenmy;
    public int health = 100;

    private void OnCollisionEnter(Collision collision)
    {
        // 충돌한 객체가 'Enemy' 태그를 가지고 있는지 확인
        if (collision.gameObject.CompareTag("enemy"))
        {
            
        }
    }
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

        // 애니메이션 파라미터 설정
        if (animator != null)
        {
            bool isMoving = (inputVec.x != 0 || inputVec.y != 0);
            animator.SetBool("ismoving", isMoving);
        }

        // 스프라이트 뒤집기
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
