 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_DE : MonoBehaviour
{
    [SerializeField] private float currentTime = 0f;
    public float startingTime = 60f;
    [SerializeField] private Text countdownText;
    static bool created = false;
    public Game_End gameEnd;
    public Plane_DE plane;

    private void Awake()
    {

        currentTime = startingTime;
    }

    private void Update()
    {
        timer();
    }

    private void timer()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        if (currentTime <= 0) { currentTime = 0; }
        if (currentTime <= 80)
        {
            plane.movementSpeed = 5;
        }
        if (currentTime <= 60)
        {
            plane.movementSpeed = 7;
            plane.timeToSpawn = 1.1;
            plane.timeToSpawnApple = 6;
        }
        if (currentTime <= 40)
        {
            plane.movementSpeed = 9;
            plane.timeToSpawn = 0.9;
            plane.timeToSpawnApple = 5;
        }
        if (currentTime <= 20)
        {
            plane.movementSpeed = 11;
            plane.timeToSpawn = 0.6;
            plane.timeToSpawnApple = 4;
        }
        if (currentTime <= 0)
        {
            gameEnd.Over();

        }


    }
}
