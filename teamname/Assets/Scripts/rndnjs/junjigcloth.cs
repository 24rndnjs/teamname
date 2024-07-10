using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class junjigcloth : MonoBehaviour
{
    public junjigdatabase artifect;
    private bool aniLogged = false; // �ִϰ� �ȴ� �α� �÷���
    private bool comicLogged = false; // ��â �ȴ� �α� �÷���
    private bool gameLogged = false; // ���� �ȴ� �α� �÷���
    private bool filmLogged = false; // ���� �ȴ� �α� �÷���
    public Sprite gameSprite;
    public Sprite comicSprite;
    public Sprite aniSprite;
    public Sprite filmSprite;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        spriteRenderer.enabled = false; // ó������ ��������Ʈ�� ��Ȱ��ȭ
    }

    void Update()
    {
        if (artifect.ani == 4 && !aniLogged)
        {
            Debug.Log("�ִϰ� �ȴ�");
            aniLogged = true; // �α� �÷��� ����
            ShowSprite(aniSprite);
        }
        if (artifect.comic == 4 && !comicLogged)
        {
            Debug.Log("��â �ȴ�");
            comicLogged = true; // �α� �÷��� ����
            ShowSprite(comicSprite);
        }
        if (artifect.game == 4 && !gameLogged)
        {
            Debug.Log("���� �ȴ�");
            gameLogged = true; // �α� �÷��� ����
            ShowSprite(gameSprite);
        }
        if (artifect.film == 4 && !filmLogged)
        {
            Debug.Log("���� �ȴ�");
            filmLogged = true; // �α� �÷��� ����
            ShowSprite(filmSprite);
        }
    }

    void ShowSprite(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
        spriteRenderer.enabled = true;
    }
}
