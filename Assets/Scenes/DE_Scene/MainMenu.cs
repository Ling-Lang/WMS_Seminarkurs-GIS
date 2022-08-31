using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game_DE");
    }

    public void QuitGame()
    {

        SceneManager.LoadScene("Scene_HUB");
    }



}
