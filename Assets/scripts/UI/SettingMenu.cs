using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class SettingMenu : MonoBehaviour
{
    public static SettingMenu Instance;

    public Slider soundSlider;
    public Slider musicSlider;
    public Button exitButton;
    public Button continueButton;
    public GameObject settingsPanel;
    public GameObject backgroundMask;

    public AudioSource soundSource;
    public AudioSource musicSource;

    private void Awake()
    {
        //后面直接选脚本然后选showsetting函数就行
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        settingsPanel.SetActive(false);
        backgroundMask.SetActive(false);

        soundSlider.onValueChanged.AddListener(AdjustSoundVolume);
        musicSlider.onValueChanged.AddListener(AdjustMusicVolume);

        exitButton.onClick.AddListener(ExitGame);
        continueButton.onClick.AddListener(HideSettings);

        soundSlider.value = soundSource.volume;
        musicSlider.value = musicSource.volume;
    }

    public void ShowSettings()
    {
        settingsPanel.SetActive(true);
        backgroundMask.SetActive(true);
        Time.timeScale = 0;
    }
    void HideSettings()
    {
        settingsPanel.SetActive(false);
        backgroundMask.SetActive(false);
        Time.timeScale = 1;
    }

    void AdjustSoundVolume(float value)
    {
        soundSource.volume = value;
    }

    void AdjustMusicVolume(float value)
    {
        musicSource.volume = value;
    }

    void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
