using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("Intro");
    }

    public void GotoEndScene()
    {
        SceneManager.LoadScene("EndScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
