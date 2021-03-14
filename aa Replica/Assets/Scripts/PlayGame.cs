using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    public InputField playername;

    public void LoadGame()
    {
        SceneManager.LoadScene("MainLevel");

        Spawner.playernamestr = playername.text;
    }


}
