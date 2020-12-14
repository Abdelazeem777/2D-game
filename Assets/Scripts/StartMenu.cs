using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public bool GameIsStoped=true;
    public static bool GameRestarted=false;

    public GameObject startMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        GameIsStoped = true;
        Time.timeScale = 0f;
        if(GameRestarted)
        StartGame();
    }


    public void StartGame()
    {
        startMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsStoped = false;
        GameRestarted=false;
    }

    public void StopGame()
    {
        startMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsStoped = true;
    }



}
