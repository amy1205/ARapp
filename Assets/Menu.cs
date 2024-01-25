using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//使用Unity UI程式庫
public class Menu : MonoBehaviour
{
    [Header("首頁")]
    public GameObject MenuPage;
    [Header("設定")]
    public GameObject SettingPage;
    //----------------------------------------------------
    [Header("控制音量的Slider")]
    public Slider ControlVolumSlider;
    [Header("AudioListener")]
    public AudioListener AudioListenerObject;
    // Start is called before the first frame update
    void Start()
    {
        AudioListener.volume= ControlVolumSlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToGame()
    {
        //切換場景
        Application.LoadLevel("AR");

    }
    public void Quit()
    {
        //關閉遊戲
        Application.Quit();

    }
    public void SetSetting(bool Set)
    {
        //控制首頁頁面開關
        MenuPage.SetActive(Set);
        //控制設定頁面開關
        SettingPage.SetActive(!Set);

    }
    public void SetMusicVolum()
    {
        //整體聲音的音量=聲音控制Slider的數值(值介於0~1之間)
        AudioListener.volume= ControlVolumSlider.value;
        //將聲音的音量儲存在SaveData腳本中的SaveVolume變數內
        SaveData.SaveVolume = AudioListener.volume;
    }
}
