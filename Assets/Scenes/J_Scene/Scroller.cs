using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
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
