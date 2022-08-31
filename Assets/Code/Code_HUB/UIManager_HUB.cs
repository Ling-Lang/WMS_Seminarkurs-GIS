using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager_HUB : MonoBehaviour
{

    private void Awake()
    {
        Time.timeScale = 0;
    }

    public void StartGame()
    {
        Time.timeScale = 1;
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void BackToGameHUB()
    {
        Time.timeScale = 1;
        GameObject.Find("pauseButton").GetComponent<Button>().Select();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        GameObject.Find("OptionSpielButton").GetComponent<Button>().Select();
    }

    public void InfoCanvas()
    {
        //muss noch gemacht werden, wird angezeigt wie Steuerung ist
        //Time.timeScale = 0;
    }

    public void goToFootballGame()
    {
        SceneManager.LoadScene("Start_Game_CM");
    }

    public void goToHitlerGame()
    {
        SceneManager.LoadScene("Map_Zone EG");
    }

    public void goToBallonGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void goToCandyGame()
    {
        SceneManager.LoadScene("Menü_DE");
    }

    public void Apfelkuchen()//Name ist von Tri
    {
        GameObject.Find("Back5Button").GetComponent<Button>().Select();
    }

    public void sStartGame()//Name ist von Chris
    {
        GameObject.Find("StartSpielButton").GetComponent<Button>().Select();
    }

    public void sPauseButton()//InGameUI
    {
        GameObject.Find("pauseButton").GetComponent<Button>().Select();
    }

    public void sSliderButton()//InGameUI
    {
        GameObject.Find("Slider").GetComponent<Slider>().Select();
    }


}
