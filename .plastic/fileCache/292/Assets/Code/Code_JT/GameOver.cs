using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject Player;
    public bool isGameOver;
    public Text gameOverText;
    public Image darken;
// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
   void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Over();
            Debug.Log("Game Over");
        }
    }
    public void Over()
    {

        Time.timeScale = 0;
        gameOverText.enabled = true;
        darken.enabled = true;
        

    }
}
