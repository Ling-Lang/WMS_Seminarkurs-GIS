using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButtonScript : MonoBehaviour
{
    [SerializeField] private GameObject StartMenuCanvas;

    public void Awake()
    {
        Time.timeScale = 0;
        StartMenuCanvas.SetActive(true);
    }
}




