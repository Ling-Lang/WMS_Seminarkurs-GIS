 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float currentTime = 0f;
    public float startingTime = 60f;
    [SerializeField] private Text countdownText;
    static bool created = false;
    public GameOver gameOver;
    public GameObject player,uizeug;

    public void Awake()
    {
        
        currentTime = startingTime;
    }

    public void Update()
    {
        uizeug = GameObject.Find("UIZeug").gameObject;
        countdownText = GameObject.Find("Text").GetComponent<Text>();
        timer();
    }

    private void timer()
    {
        
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        if (currentTime <= 0) { currentTime = 0; }
        if(currentTime <= 0)
        {
         gameOver.Over();

        }
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
    
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            currentTime = startingTime;
        }
    }
}