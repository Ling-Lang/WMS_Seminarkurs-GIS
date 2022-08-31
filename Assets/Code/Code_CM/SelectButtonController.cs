using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButtonController : MonoBehaviour
{
    

    public void sResumeButton()//select Resume Button Option Menu
    {
        GameObject.Find("Resume_Button").GetComponent<Button>().Select();
    }

    public void sPlayer1Button()//Steuerung_Canvas
    {
        GameObject.Find("Spieler_1_Button").GetComponent<Button>().Select();
    }

    public void sSoundOnButton()//Option Menu
    {
        GameObject.Find("SoundON_Button").GetComponent<Button>().Select();
    }

    public void sReturn1Button()//Controler Spieler 1
    {
        GameObject.Find("Back1_Button").GetComponent<Button>().Select();
    }

    public void sReturn2Button()//Controller Spieler 2
    {
        GameObject.Find("Back2_Button").GetComponent<Button>().Select();
    }

    public void sExitButton() //Steuerung Canvas
    {
        GameObject.Find("Back_Button").GetComponent<Button>().Select();
    }

    public void sPauseButton()//InGameUI
    {
        GameObject.Find("PauseTaste").GetComponent<Button>().Select();
    }

    public void sBackToMenuButton()//Pause Menu
    {
        GameObject.Find("BtM_Button").GetComponent<Button>().Select();
    }
}
