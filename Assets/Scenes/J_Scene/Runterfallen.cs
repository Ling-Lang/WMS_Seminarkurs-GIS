using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runterfallen : MonoBehaviour
{
    private int scrollSpeed = 100;
    void Update()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.y -= scrollSpeed * Time.deltaTime;
        transform.position = currentPosition;
    }
    void Start()
    {
        Vector3 currentPosition = transform.position;
    }
}
