using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject InGameUICanvas;
    [SerializeField] private GameObject PauseMenuCanvas;
    [SerializeField] private GameObject OptionMenuCanvas;
    [SerializeField] private GameObject StartMenuCanvas;
    [SerializeField] private GameObject EndingCanvas;
    [SerializeField] private GameObject Unentschieden_Button;
    [SerializeField] private GameObject Niederlage_Button;
    [SerializeField] private GameObject Sieg_Button;

    [SerializeField] private GameObject SteuerungCanvas;
    [SerializeField] private GameObject SteuerungPeins;
    [SerializeField] private GameObject SteuerungPzwei;

    [SerializeField] private Text rightPointText;
    [SerializeField] private Text leftPointText;
    [SerializeField] private Text leftPointText2;
    [SerializeField] private Text rightPointText2;

    [SerializeField] private AudioSource jumpSoundEffect;
    [SerializeField] private AudioSource shootSoundEffect;
    [SerializeField] private AudioSource winSoundEffect;
    [SerializeField] private AudioSource torSoundEffect;

    [SerializeField] private AudioSource musicSoundEffect;

    private int tor = 0;
    private bool won = false;

    private int a = 1, b = 1; //win Sound nur einmal abspielen

    private int rightPoints = 0, leftPoints = 0, zero = 0;


    private int timeOver = 0;
   
    public void Awake()
    {
        Instance = this;
    }

    public void Start()
    {
        Time.timeScale = 1;

        InGameUICanvas.SetActive(true);
        PauseMenuCanvas.SetActive(false);
        OptionMenuCanvas.SetActive(false);
        StartMenuCanvas.SetActive(false);
        EndingCanvas.SetActive(false);

        SteuerungCanvas.SetActive(false);
        SteuerungPeins.SetActive(false);
        SteuerungPzwei.SetActive(false);

        timeOver = 0;
        rightPoints = 0;
        leftPoints = 0;
    }

    public void Update()
    {
        PointCounter();
        DecideState();
        
        rightPointText.text = rightPoints.ToString();
        leftPointText.text = leftPoints.ToString();
    }

    public void Music(bool play)
    {
        if(play == true)
        {
            if(b == 1)
            {
                musicSoundEffect.Play();
            }
            b++;
            musicSoundEffect.loop = true;
        }
        else
        {
            musicSoundEffect.Stop();
            b = 1;
        }
       
    }

    public void Sound(bool play)
    {
        if (play == true)
        {
            if((PlayerScript_CM.Instance.isJumped() == true) || (PlayerTwoScript_CM.Instance.isJumped() == true))
            {
                jumpSoundEffect.Play();
                //Debug.Log("Jump Audio");
            }

            if((PlayerScript_CM.Instance.isShot() == true) || (PlayerTwoScript_CM.Instance.isShot() == true))
            {
                shootSoundEffect.Play();
                //Debug.Log("Schuss Audio");
            }

            if(won == true)
            {
                if(a == 1)
                {
                    winSoundEffect.Play();
                }
                a++;
            }

            if(tor == 1)
            {
                torSoundEffect.Play();
            }

            if (tor == 2)
            {
                torSoundEffect.Play();
            }
        }
    }

    public void PointCounter()
    {
        switch (BallScript_CM.Instance.gibTor())
        {
            case 1://Tor rechts
                if(timeOver == 0)
                {
                    leftPoints++;
                    leftPointText.text = leftPoints.ToString();
                    BallScript_CM.Instance.Spawnball(0);
                    PlayerScript_CM.Instance.SpawnPlayer();
                    PlayerTwoScript_CM.Instance.SpawnPlayer();
                    tor = 1;
                }
                break;
            case 2://Tor links
                if(timeOver == 0)
                {
                    rightPoints++;
                    rightPointText.text = rightPoints.ToString();
                    BallScript_CM.Instance.Spawnball(0);
                    PlayerScript_CM.Instance.SpawnPlayer();
                    PlayerTwoScript_CM.Instance.SpawnPlayer();
                    tor = 2;
                }
                break;
            default:
                tor = 0;
                break;
        }  
    }

    public void restartPoints()
    {
        rightPointText.text = zero.ToString();
        leftPointText.text = zero.ToString();
    }

      public void DecideState()
      {
        if (CounterScript_CM.Instance.zeitAbgelaufen() == true && Time.timeScale == 1)
          {
              rightPointText2.text = rightPoints.ToString();
              leftPointText2.text = leftPoints.ToString();
              timeOver = 1;
              InGameUICanvas.SetActive(false);
              EndingCanvas.SetActive(true);
              if (rightPoints < leftPoints)
              {
                GameObject.Find("Sieg_Button").GetComponent<Button>().Select();
                Sieg_Button.SetActive(true);
                Unentschieden_Button.SetActive(false);
                Niederlage_Button.SetActive(false);
                Debug.Log("GEWONNEN");
                won = true;
              }

              if (rightPoints > leftPoints)
              {
                GameObject.Find("Niederlage_Button").GetComponent<Button>().Select();
                Sieg_Button.SetActive(false);
                Unentschieden_Button.SetActive(false);
                Niederlage_Button.SetActive(true);
                Debug.Log("VERLOREN");
                won = true;
              }
              
              if (rightPoints == leftPoints)
              {
                GameObject.Find("Unentschieden_Button").GetComponent<Button>().Select();
                Sieg_Button.SetActive(false);
                Unentschieden_Button.SetActive(true);
                Niederlage_Button.SetActive(false);
                Debug.Log("UNENTSCHIEDEN");
              }
          }
          else
          {
            timeOver = 0;
            EndingCanvas.SetActive(false);
            won = false;
          }
      }
}



