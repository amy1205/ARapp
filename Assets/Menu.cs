using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
}
