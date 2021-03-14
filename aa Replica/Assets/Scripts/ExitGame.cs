using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
