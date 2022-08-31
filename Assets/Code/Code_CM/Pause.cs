using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public void PauseTheGame()
    {
        Time.timeScale = 0;
        GameObject.Find("OptionSpielButton").GetComponent<Button>().Select();
    }
    public void BackToGameDE()
    {
        Time.timeScale = 1;
        GameObject.Find("pauseButton").GetComponent<Button>().Select();
    }
}
