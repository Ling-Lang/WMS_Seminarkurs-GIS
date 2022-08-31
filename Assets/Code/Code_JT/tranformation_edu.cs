using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tranformation_edu : MonoBehaviour
{
    public GameObject schnegge,player;
    public Sprite eduei;
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
            player.GetComponent<SpriteRenderer>().sprite = eduei;
        }
    }
}
