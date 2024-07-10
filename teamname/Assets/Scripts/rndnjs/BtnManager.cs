using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManager : MonoBehaviour
{
    void Start()
    {
        // 스테이지 버튼 상태 초기화
        InitializeStageButtons();
    }

    public void mainBtnOnclick()
    {
        SceneManager.LoadScene("stageselect");
    }

    public void creditBtnOnclick()
    {
        SceneManager.LoadScene("Credit");
    }

    public void quitBtnClick()
    {
        Application.Quit();
    }

    public void firststageBtn()
    {
        SceneManager.LoadScene("1stage");
    }

    public void secondstageBtn()
    {
        if (PlayerPrefs.GetInt("Stage1Cleared", 0) == 1)
        {
            SceneManager.LoadScene("2stage");
        }
        else
        {
            Debug.Log("Stage 2 is locked. Clear Stage 1 first.");
        }
    }

    public void thirdstageBtn()
    {
        if (PlayerPrefs.GetInt("Stage2Cleared", 0) == 1)
        {
            SceneManager.LoadScene("3stage");
        }
        else
        {
            Debug.Log("Stage 3 is locked. Clear Stage 2 first.");
        }
    }

    public void fourstageBtn()
    {
        if (PlayerPrefs.GetInt("Stage3Cleared", 0) == 1)
        {
            SceneManager.LoadScene("4stage");
        }
        else
        {
            Debug.Log("Stage 4 is locked. Clear Stage 3 first.");
        }
    }

    void InitializeStageButtons()
    {
        
        GameObject secondStageButton = GameObject.Find("SecondStageButton");
        GameObject thirdStageButton = GameObject.Find("ThirdStageButton");
        GameObject fourthStageButton = GameObject.Find("FourthStageButton");

        if (secondStageButton != null)
        {
            secondStageButton.GetComponent<UnityEngine.UI.Button>().interactable = PlayerPrefs.GetInt("Stage1Cleared", 0) == 1;

        }

        if (thirdStageButton != null)
        {
            thirdStageButton.GetComponent<UnityEngine.UI.Button>().interactable = PlayerPrefs.GetInt("Stage2Cleared", 0) == 1;
        }

        if (fourthStageButton != null)
        {
            fourthStageButton.GetComponent<UnityEngine.UI.Button>().interactable = PlayerPrefs.GetInt("Stage3Cleared", 0) == 1;
        }
    }
}
