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

    public Slider healthSlider;
    public float curHealth = 100; //* ���� ü��
    public float maxHealth; //* �ִ� ü��

    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        maxHealth = curHealth;
        healthSlider.maxValue = maxHealth; // �����̴� �ִ밪 ����
        healthSlider.value = curHealth;//�ʱ� ü�� �����̴��� �ݿ�
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
    private void OnTriggerEnter2D(Collider2D other)
    {
        // �浹�� ��ü�� 'Enemy' �±׸� ������ �ִ��� Ȯ��
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
    }

}
