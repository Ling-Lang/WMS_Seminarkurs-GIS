using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ui_events : MonoBehaviour
{
    public TMP_Text gameOverText;
    public Image darken;
    public Image darken_banner;
    public Button tryAgain;
    public Image btn1;
    public TMP_Text btn1_text;
    public Button wakeup;
     public TMP_Text btn2_text;
    public Image btn2;
    public Timer timer;
    public AudioSource ads;
    public Slider slider;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        gameOverText = GameObject.Find("GameOver").GetComponent<TMP_Text>();
        darken = GameObject.Find("Darken").GetComponent<Image>();
        darken_banner = GameObject.Find("Gameover_Banner").GetComponent<Image>();
        tryAgain =GameObject.Find("btn_tryagain").GetComponent<Button>();
        btn1 = GameObject.Find("btn_tryagain").GetComponent<Image>();
        btn1_text = GameObject.Find("btn_tryagain").GetComponentInChildren<TMP_Text>();
        wakeup = GameObject.Find("btn_wake_up").GetComponent<Button>();
        btn2_text = GameObject.Find("btn_wake_up").GetComponentInChildren<TMP_Text>();
        btn2 =GameObject.Find("btn_wake_up").GetComponent<Image>();
        slider = GameObject.Find("UIZeug").transform.Find("Panel").transform.Find("Slider").GetComponent<Slider>();
        ads = GameObject.Find("Spawnpoint").GetComponent<AudioSource>();
                if(Input.GetButtonDown("Controller Menu"))
        {
          GameObject.Find("UIZeug").transform.Find("Panel").transform.Find("Back").GetComponent<Button>().Select();
          GameObject.Find("pauseButton").GetComponent<Button>().onClick.Invoke();
        }
        ads.volume = slider.value;
    }

    public void try_again(){
        //timer.startingTime = 10;
        Time.timeScale = 1;
        GameObject.Find("Player").transform.position=GameObject.Find("Spawnpoint").transform.position;
        SceneManager.LoadScene(2);
        Debug.Log("try again");
        ads.Play();
        gameOverText.enabled = false;
        darken_banner.enabled = false;
        darken.enabled = false;
        tryAgain.enabled = false;
        btn1.enabled = false;
        btn1_text.enabled = false;
        wakeup.enabled = false;
        btn2.enabled = false;
        btn2_text.enabled = false; 
        
    }

    public void wake_up(){
        SceneManager.LoadScene(0);
    }
}
