using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Canvas : MonoBehaviour
{

    private void Awake()
    {
        Time.timeScale = 0;
    }

    public void SpielStart()
    {
        SceneManager.LoadScene("Game_1");
        Time.timeScale = 1;
    }

    public void Hub()
    {
        SceneManager.LoadScene("Scene_HUB");
    }
}
