using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Wincon : MonoBehaviour
{
    public TMP_Text winText;
    public Image darken;
    public Image darken_banner;
    public Button tryAgain;
    public Image btn1;
    public TMP_Text btn1_text;
    public Button wakeup;
     public TMP_Text btn2_text;
    public Image btn2;
    public GameObject player,hitler,bomb;
        static bool created = false;
    public bool BombInRange,bombnearhitler,playerinEG,block;
    public Collider2D tilemap;
    void Awake()
    {
        darken = GameObject.Find("Darken").GetComponent<Image>();
        darken_banner = GameObject.Find("Gameover_Banner").GetComponent<Image>();
        tryAgain =GameObject.Find("btn_tryagain").GetComponent<Button>();
        btn1 = GameObject.Find("btn_tryagain").GetComponent<Image>();
        btn1_text = GameObject.Find("btn_tryagain").GetComponentInChildren<TMP_Text>();
        wakeup = GameObject.Find("btn_wake_up").GetComponent<Button>();
        btn2_text = GameObject.Find("btn_wake_up").GetComponentInChildren<TMP_Text>();
        btn2 =GameObject.Find("btn_wake_up").GetComponent<Image>();
        winText = GameObject.Find("WinText").GetComponent<TMP_Text>();
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
        winText.enabled = false;
            Time.timeScale = 1;
            darken_banner.enabled = false;
            darken.enabled = false;
            tryAgain.enabled = false;
            btn1.enabled = false;
            btn1_text.enabled = false;
            wakeup.enabled = false;
            btn2.enabled = false;
            btn2_text.enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        darken = GameObject.Find("Darken").GetComponent<Image>();
        darken_banner = GameObject.Find("Gameover_Banner").GetComponent<Image>();
        tryAgain =GameObject.Find("btn_tryagain").GetComponent<Button>();
        btn1 = GameObject.Find("btn_tryagain").GetComponent<Image>();
        btn1_text = GameObject.Find("btn_tryagain").GetComponentInChildren<TMP_Text>();
        wakeup = GameObject.Find("btn_wake_up").GetComponent<Button>();
        btn2_text = GameObject.Find("btn_wake_up").GetComponentInChildren<TMP_Text>();
        btn2 =GameObject.Find("btn_wake_up").GetComponent<Image>();
        winText = GameObject.Find("WinText").GetComponent<TMP_Text>();
        hitler = GameObject.Find("Hitler");
        if(tilemap == null){
            bomb = GameObject.Find("bomb(Clone)");
            playerinEG=false;
        }
        
        this.player = GameObject.Find("Player");
        if(hitler == null){
          tilemap = GameObject.Find("Grass").GetComponent<Collider2D>();
        }
      
        
        ausgangcheck();
        if(tilemap==null&& bomb != null){
        bomb.GetComponent<SpriteRenderer>().sortingOrder =3;
        bombcheck();

        }

        if(BombInRange&& !block){
            bombnearhitler=true;
        }
        if(bomb!=null)
        {
            block = false;
        }
        
        Win();
    }


     private void bombcheck()
      {
        BombInRange=Physics2D.OverlapCircle(bomb.transform.position,5f,LayerMask.GetMask("Hitler"));
      }
    private void ausgangcheck()
    {
        playerinEG= Physics2D.OverlapCircle(player.transform.position,1000f,LayerMask.GetMask("Grass"));
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            bombnearhitler=false;
            block=true;
        }
    }
    private void Win()
    {
        if(playerinEG&&bombnearhitler){

            //Jens macht hier UI zeug
            winText.enabled = true;
            Time.timeScale = 0;
            darken_banner.enabled = true;
            darken.enabled = true;
            tryAgain.enabled = true;
            btn1.enabled = true;
            btn1_text.enabled = true;
            wakeup.enabled = true;
            btn2.enabled = true;
            btn2_text.enabled = true; 
        }
    }
}
