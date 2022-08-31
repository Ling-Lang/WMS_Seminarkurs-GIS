using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerHUB : MonoBehaviour
{
    public GameObject StartCanvas;
    public GameObject PauseCanvas;
    public GameObject OptionCanvas;
    public GameObject CreditsCanvas;
    public GameObject InGameCanvas;
    public GameObject sFootballCanvas;
    public GameObject sCandyCanvas;
    public GameObject sHitlerCanvas;
    public GameObject sBallonCanvas;

    public static GameManagerHUB Instance { get; private set; }

    private int levelNumber;
    private float inInteract;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        

    }

    private void Start()
    {
        StartCanvas.SetActive(true);
        PauseCanvas.SetActive(false);
        OptionCanvas.SetActive(false);
        CreditsCanvas.SetActive(false);
        InGameCanvas.SetActive(false);
        sFootballCanvas.SetActive(false);
        sCandyCanvas.SetActive(false);
        sHitlerCanvas.SetActive(false);
        sBallonCanvas.SetActive(false);
        GameObject.Find("Canvas").transform.Find("StartCanvas").transform.Find("StartSpielButton").GetComponent<Button>().Select();
    }

    private void Update()
    {
        DecideLevel();
    }


    private void DecideLevel()
    {
        if (Movement_player_hub.Instance.gibCollisionFootball() == true)
        {
            sFootballCanvas.SetActive(true);
            GameObject.Find("PlayButton").GetComponent<Button>().Select();
            Time.timeScale = 1;
        }
        else { sFootballCanvas.SetActive(false);
            
        }

        if (Movement_player_hub.Instance.gibCollisionHitler() == true)
        {
            sHitlerCanvas.SetActive(true);
            GameObject.Find("PlayButton").GetComponent<Button>().Select();
            Time.timeScale = 1;
        }
        else { sHitlerCanvas.SetActive(false);
            
        }

        if (Movement_player_hub.Instance.gibCollisionCandy() == true)
        {
            sCandyCanvas.SetActive(true);
            GameObject.Find("PlayButton").GetComponent<Button>().Select();
            Time.timeScale = 1;
        }
        else { sCandyCanvas.SetActive(false);
            
        }

        if (Movement_player_hub.Instance.gibCollisionBallon() == true)
        {
            sBallonCanvas.SetActive(true);
            GameObject.Find("PlayButton").GetComponent<Button>().Select();
            Time.timeScale = 1;
        }
        else { sBallonCanvas.SetActive(false);
            
        }
        //Wenn kein Level angesprochen wird, dann wird der Pause Button ausgew?hlt (Controller)
        if(GameObject.Find("Canvas").transform.Find("StartCanvas").gameObject.activeSelf==false &&
            (Movement_player_hub.Instance.gibCollisionBallon() == false) &&
            (Movement_player_hub.Instance.gibCollisionHitler() == false) &&
            (Movement_player_hub.Instance.gibCollisionFootball() == false) &&
            (Movement_player_hub.Instance.gibCollisionCandy() == false))
        {
            GameObject.Find("pauseButton").GetComponent<Button>().Select();
        }
        
    }



}
