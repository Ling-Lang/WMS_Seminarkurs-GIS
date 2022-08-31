using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public class music : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider sl;
    // Start is called before the first frame update
    void Start()
    {
        sl.value = 0.2f;
        audioSource.Play();
        
               
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume =  sl.value;  
    }
}
