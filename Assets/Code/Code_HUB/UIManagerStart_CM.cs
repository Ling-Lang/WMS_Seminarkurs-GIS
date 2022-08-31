using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerStart_CM : MonoBehaviour
{
    public void BackToHUB()
    {
        SceneManager.LoadScene("Scene_HUB");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game_CM");
    }
}
