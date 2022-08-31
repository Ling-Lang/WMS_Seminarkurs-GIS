using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tranformation : MonoBehaviour
{
    public GameObject schnegge,player;
    public Sprite schneggei;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        schnegge = GameObject.Find("EasterEgg1");
        player = GameObject.Find("PLayer");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            player.GetComponent<SpriteRenderer>().sprite = schneggei;
        }
    }
}
