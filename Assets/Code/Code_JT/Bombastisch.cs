using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Bombastisch : MonoBehaviour
{
public AudioSource audioSource;
public ParticleSystem pS;
 private Int16 isPickedUp = 0;
 public Rigidbody2D rb;
 private bool Hitler;
 private GameOver gameOver;

 private GameObject player;
 public GameObject bomb;
 
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        switch (isPickedUp)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.E)||Input.GetButtonDown("Controller Bomb"))
                {
                    isPickedUp = 1;

                     Instantiate(bomb, player.transform.position,Quaternion.identity);
                }
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.E)||Input.GetButtonDown("Controller Bomb"))
                {
                 Debug.Log("Booom");
                }
                break;
            default:
                break;
        }
    }
    //create a function that will be called when the bomb is armed

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            isPickedUp=0;
            GameObject.Find("btn_tryagain").GetComponent<Button>().Select();
        }
    }

}
