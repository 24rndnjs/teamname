using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 10;

    public Vector2 inputVec;
    Animator animator;
    SpriteRenderer spriteRenderer;

    public Slider healthSlider;
    public Slider manaslider;
    public float maxmana = 100f; // 초기 최대 마나 설정
    public float curmana = 0f; // 초기 현재 마나 설정
    public float curHealth = 100; // 현재 체력
    public float maxHealth; // 최대 체력
    public Database player;
    public float mana = 10f; // 충돌 시 증가할 마나량

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        maxHealth = curHealth;
        healthSlider.maxValue = maxHealth; // 슬라이더 최대값 설정
        healthSlider.value = curHealth; // 초기 체력 슬라이더에 반영

        manaslider.maxValue = maxmana; // 마나 슬라이더 최대값 설정
        manaslider.value = curmana; // 초기 마나 슬라이더에 반영

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

    private void OnTriggerEnter2D(Collider2D other)
    {
        // 충돌한 객체가 'Enemy' 태그를 가지고 있는지 확인
        if (other.gameObject.CompareTag("enemy"))
        {
            Debug.Log(other.gameObject.name);
            float damage = other.gameObject.GetComponent<enemy>().enemydata.attack;

            curHealth -= damage;
            healthSlider.value = curHealth;

            if (curHealth <= 0)
            {
                Debug.Log("Player died.");
            }
        }
        if (other.gameObject.CompareTag("mana"))
        {
            Destroy(other.gameObject); // 충돌한 mana 오브젝트를 파괴
            curmana += mana;
            if (curmana >= maxmana)
            {
                curmana = 0;
                maxmana *= 1.1f;
                manaslider.maxValue = maxmana; // 마나 슬라이더의 최대값 업데이트
            }
            manaslider.value = curmana; // 마나 슬라이더 업데이트
        }
    }
}
