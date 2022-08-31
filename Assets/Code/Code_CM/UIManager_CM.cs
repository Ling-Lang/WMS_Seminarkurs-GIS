using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager_CM : MonoBehaviour
{
    private static bool soundState, musicState; 

    public void Start()
    {
        soundState = true;
        musicState = true;
    }
    

    public void Update()
    {
        if(soundState == false)
        {
            GameManager.Instance.Sound(false);
            //Debug.Log("Sound ist offffff");
        }
        else
        {
            GameManager.Instance.Sound(true);
            //Debug.Log("Sound ist onnnnnnn");
        }

        if(musicState == false)
        {
            GameManager.Instance.Music(false);
            //Debug.Log("Musik ist offffffffff");
        }
        else
        {
            GameManager.Instance.Music(true);
            //Debug.Log("Musik ist onnnnnnn");
        }


    }
    public void Paused()
    {
        Time.timeScale = 0;
    }


    public void BackToHUB()
    {
        SceneManager.LoadScene("Scene_HUB");
    }

    public void MusicON()
    {
        musicState = true;
    }

    public void MusicOFF()
    {
        musicState = false; 
    }

    public void SoundON()
    {
        soundState = true;
    }

    public void SoundOFF()
    {
        soundState = false;
    }

    public void BackToGame() 
    {
        Time.timeScale = 1;
        
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene("Game_CM");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game_CM");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Start_Game_CM");
    }
    public void NeuesSpiel()
    {
        SceneManager.LoadScene("Start_Game_CM");
    }
}

