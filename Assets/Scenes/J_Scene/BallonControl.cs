using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class BallonControl : MonoBehaviour
{
    [SerializeField] private GameObject Verlorencanvas;
    [SerializeField] private GameObject Gewonnencanvas;

    //private BallonM
    private float movement;
    public int walkSpeed;
    private int r_1 = 2;
    private int r_2 = 15;
    public bool verloren = false;

    private Rigidbody2D rbP; //Rigidbody Player

    public static BallonControl Instance;

    [SerializeField] private float currentTime = 0f;
    [SerializeField] private float startingTime = 15f;
    [SerializeField] private float currentTime1 = 0f;
    [SerializeField] private float startingTime1 = 120f;

    private float rotZ = 0;
    public float rotationSpeed;
    public bool clockwiseRotation;

    private void Awake()
    {
        //ballonMovement = new BallonMovement();
        Debug.Log("ballonM");

        Instance = this;
        Debug.Log("this");
;       currentTime = startingTime;
        currentTime1 = startingTime1;

        Debug.Log("time");
    }

    private void OnEnable()
    {
        //ballonMovement.Enable();
        Debug.Log("enable");
    }

    private void OnDisable()
    {
        //ballonMovement.Disable();
    }

    private void FixedUpdate()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * walkSpeed;

        //Player Movement
        //movement = ballonMovement.Ballon.Movement.ReadValue<float>();
        //Debug.Log("movement");

        //Vector3 currentPosition = transform.position;
        //currentPosition.x += movement * walkSpeed * Time.deltaTime;
        //transform.position = currentPosition;
        //Debug.Log("position");

        //Random Wind


        if (currentTime <= 10 && Time.timeScale == 1)
        {
            r_1 = Random.Range(0, 3);
            Debug.Log(r_1);

            r_2 = Random.Range(12, 20);
            startingTime = r_2;
            Debug.Log(r_2);


            restartTime();
        }



        switch (r_1)
        {
            case 0:
                transform.Translate(4F, 0F, 0F);
                rotZ += Time.deltaTime * rotationSpeed;
                break;

            case 1:
                transform.Translate(-4F, 0F, 0F);
                rotZ += -Time.deltaTime * rotationSpeed;
                break;

            case 2:
                transform.Translate(0F, 0F, 0F);
                break;

        }

        

        Timer();
        Timer1();

        if (currentTime1 <= 10 && Time.timeScale == 1)
        {
            Gewonnencanvas.SetActive(true);
            Debug.Log("YEA");
        }


        
    }



    private void Timer()
    {
        currentTime -= 1 * Time.deltaTime;
        //Debug.Log(currentTime);
        if (currentTime <= 0) { currentTime = 0; }
    }

    private void Timer1()
    {
        currentTime1 -= 1 * Time.deltaTime;
        //Debug.Log(currentTime);
        if (currentTime1 <= 0) { currentTime1 = 0; }
    }

    public void restartTime()
    {
        currentTime = startingTime;
    }

    private void start()
    {
        rbP = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "rMauer")
        {
            verloren = true;
            Debug.Log("OOF");

            Verlorencanvas.SetActive(true);
        }

        if (collision.gameObject.tag == "lMauer")
        {
            verloren = true;
            Debug.Log("OOF");

            Verlorencanvas.SetActive(true);
        }

        if (collision.gameObject.tag == "rotateback")
        {
            var movement = Input.GetAxis("Horizontal");
            transform.position += new Vector3(0, movement, 0) * Time.deltaTime * walkSpeed;
        }

        if (collision.gameObject.tag == "rotateback1")
        {
            //rbP.AddForce(1, 400 * Time.deltaTime);
        }
    }

    void Update()
    {
        
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
