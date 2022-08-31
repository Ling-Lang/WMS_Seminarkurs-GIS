using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Threading;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject Player,Hitler;
    public bool isGameOver;
    public TMP_Text gameOverText;
    public Image darken;
    public Image darken_banner;
    public Button tryAgain;
    public Image btn1;
    public TMP_Text btn1_text;
    public Button wake_up;
     public TMP_Text btn2_text;
    public Image btn2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Hitler = GameObject.Find("Hitler");
        Player = GameObject.Find("Player");
        gameOverText = GameObject.Find("GameOver").GetComponent<TMP_Text>();
        darken = GameObject.Find("Darken").GetComponent<Image>();
        darken_banner = GameObject.Find("Gameover_Banner").GetComponent<Image>();
        tryAgain =GameObject.Find("btn_tryagain").GetComponent<Button>();
        btn1 = GameObject.Find("btn_tryagain").GetComponent<Image>();
        btn1_text = GameObject.Find("btn_tryagain").GetComponentInChildren<TMP_Text>();
        wake_up = GameObject.Find("btn_wake_up").GetComponent<Button>();
        btn2_text = GameObject.Find("btn_wake_up").GetComponentInChildren<TMP_Text>();
        btn2 =GameObject.Find("btn_wake_up").GetComponent<Image>();
        
        
        if (isGameOver)
        {
            
            if(Hitler!=null)
            {
                SceneManager.LoadScene(2);
                Player.transform.position = new Vector3(0,-36,0);
                isGameOver=false;
            }
            else{
                Over();
                isGameOver=false;
            }
            
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            isGameOver=true;
        }
    }
    public void Over()
    {
        
        gameOverText.enabled = true;
        darken_banner.enabled = true;
        darken.enabled = true;
        tryAgain.enabled = true;
        btn1.enabled = true;
        btn1_text.enabled = true;
        wake_up.enabled = true;
        btn2.enabled = true;
        btn2_text.enabled = true;
        Time.timeScale = 0;
        

    }
}
