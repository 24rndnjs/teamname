using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class junjigcloth : MonoBehaviour
{
    public junjigdatabase artifect;
    private bool aniLogged = false; // 애니가 된다 로그 플래그
    private bool comicLogged = false; // 만창 된다 로그 플래그
    private bool gameLogged = false; // 게임 된다 로그 플래그
    private bool filmLogged = false; // 영상 된다 로그 플래그
    public Sprite gameSprite;
    public Sprite comicSprite;
    public Sprite aniSprite;
    public Sprite filmSprite;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
        spriteRenderer.enabled = false; // 처음에는 스프라이트를 비활성화
    }

    void Update()
    {
        if (artifect.ani == 4 && !aniLogged)
        {
            Debug.Log("애니가 된다");
            aniLogged = true; // 로그 플래그 설정
            ShowSprite(aniSprite);
        }
        if (artifect.comic == 4 && !comicLogged)
        {
            Debug.Log("만창 된다");
            comicLogged = true; // 로그 플래그 설정
            ShowSprite(comicSprite);
        }
        if (artifect.game == 4 && !gameLogged)
        {
            Debug.Log("게임 된다");
            gameLogged = true; // 로그 플래그 설정
            ShowSprite(gameSprite);
        }
        if (artifect.film == 4 && !filmLogged)
        {
            Debug.Log("영상 된다");
            filmLogged = true; // 로그 플래그 설정
            ShowSprite(filmSprite);
        }
    }

    void ShowSprite(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
        spriteRenderer.enabled = true;
    }
}
