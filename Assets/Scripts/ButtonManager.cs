using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject resumeMenu;

    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }

    public void Pause()
    {
        Time.timeScale = 0;
        resumeMenu.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        resumeMenu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}