using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript_CM : MonoBehaviour
{
    public static CounterScript_CM Instance;

    //Timer
    [SerializeField] private float currentTime = 0f;
    [SerializeField] private float startingTime = 60f;
    [SerializeField] private Text countdownText;

    public void Awake()
    {
        Instance = this;
        currentTime = startingTime;
    }

    public void Update()
    {
        Timer();
    }

    private void Timer()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        if (currentTime <= 0) { currentTime = 0; }
    }

    public bool zeitAbgelaufen()
    {
        if (currentTime <= 0 && Time.timeScale == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    } 

    public void restartTime()
    {
        currentTime = startingTime;
    }
}
