using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject player,uizeug;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        uizeug = GameObject.Find("UIZeug").gameObject;
        player.transform.position=GameObject.Find("Spawnpoint").transform.position;
        
        player.GetComponent<SpriteRenderer>().enabled=true;
        player.GetComponent<Rigidbody2D>().bodyType=RigidbodyType2D.Dynamic;
        GameObject.Find("Player").GetComponent<Wincon>().enabled=true;
        player.GetComponent<GameOver>().enabled=true;
        player.GetComponent<Timer>().enabled=true;
        GameObject.Find("Player").GetComponentInChildren<Camera>().enabled=true;
        GameObject.Find("Player").GetComponentInChildren<AudioListener>().enabled=true;
        uizeug.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
