using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GBButtomHandler : MonoBehaviour
{
    public void OnBeginButtonClick()
    {
        Debug.Log("点击了开始游戏按钮");
        // SceneManager.LoadScene("");
    }

    public void OnQuitButtonClick()
    {
        Debug.Log("点击了退出游戏按钮");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
