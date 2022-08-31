using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Threading;
using TMPro;

public class Game_End : MonoBehaviour
{
    public GameObject Player;
    public bool isGameOver;
    public TMP_Text gameOverText;
    public Image darken;
    public Image darken_banner;
    public float score;
    public static float highscore;
    
    
    public Button wake_up;
    public TMP_Text btn2_text;
    public Image btn2;
    public TMP_Text Highscore;
    public CollectCandy candy;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            Over();

        }
    }
    public void Over()
    {
        score = candy.punkte;
        
            highscore = score;
            Highscore.text = "Score: " + highscore.ToString();
        


        gameOverText.enabled = true;
        darken_banner.enabled = true;
        darken.enabled = true;
        wake_up.enabled = true;
        btn2.enabled = true;
        btn2_text.enabled = true;
        Highscore.enabled = true;
        Time.timeScale = 0;


    }
}
