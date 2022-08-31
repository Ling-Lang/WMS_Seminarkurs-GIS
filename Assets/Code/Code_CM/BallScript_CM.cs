using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript_CM : MonoBehaviour
{

    private Vector2 startPos;
    private Rigidbody2D rbB;

    private int tor = 0;

    public static BallScript_CM Instance { get; private set; }

    public void Awake()
    {
        Instance = this;
    }

    public void Start()
    {
        startPos = transform.position;
        rbB = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        if (tor == 1) Debug.Log("Tor rechts");
        if (tor == 2) Debug.Log("Tor links");
    }

    public void FixedUpdate()
    {
    }

    public void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "rTor")
        {
            tor = 1;
        }

        if (col.gameObject.tag == "lTor")
        {
            tor = 2;
        }

    }

    public int gibTor()//übergibt an den GameManager
    {
        return tor;
    }

    public void Spawnball(int x)
    {
        tor = x; //hier wird das Tor wieder auf 0 gesetzt;
        rbB.velocity = new Vector2(0, rbB.velocity.y);
        transform.position = startPos;
    }

}
