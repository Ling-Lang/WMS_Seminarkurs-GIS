using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class music_jt : MonoBehaviour
{
    public AudioSource start;
    public GameObject hub_player;
    bool mus;
    // Start is called before the first frame update
    void Start()
    {
        mus = true;
        start.Play();
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        hub_player = GameObject.Find("PlayerHub");
        if(hub_player == null && mus == true){
            mus = false;
            Debug.Log("music_jt");
            start.Play();
        }
    } 
}


