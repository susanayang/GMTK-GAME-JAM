using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GOButtomHandler : MonoBehaviour
{
    public void OnRetryButtonClick()
    {
        Debug.Log("点击了重新开始按钮（后续会改成切换到主场景）");
    }

    public void OnQuitButtonClick()
    {
        Debug.Log("点击了退出按钮");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
