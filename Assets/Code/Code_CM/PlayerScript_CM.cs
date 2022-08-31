using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript_CM : MonoBehaviour
{
    //public float ballYabstandCol;

    private Rigidbody2D rbP; //Rigidbody Player
    private SpriteRenderer spP; //Sprite Renderer Player
    private GameObject ball; //für collision and shoot

    //Input System
    private Vector2 inWalk; //Laufrichtung
    private float inJump;
    private float inShootV;
    private float inShootH;

    //Forces for the ball; die Werte sind Fix
    private float addForce_x = 700, addForce_y = 700;
    private float addForceHead_x = 600, addForceHead_y = 300;
    private float headValueX, headValueY;
    private bool colWithBall;

    //Ground Check
    private bool grounded;
    public Transform groundCol;
    public LayerMask ground_layer;
    private float GroundOverlapRadius = 2.2f;//it's perfect, don't change

    //Head Check
    private bool headed;
    public Transform headCol;
    public LayerMask ball_layer;
    private float HeadOverlapRadius = 0.8f;//radius 0.8f is perfect

    //Values of the Player
    private int jumpHeight = 9;
    private float speed = 350;
    private Vector2 startPos;

    //Audio Stuff
    private bool jumpP, shootP;

    private Player_Input_CM playerInput;
    public static PlayerScript_CM Instance { get; private set; }

    private void Awake()
    {
        playerInput = new Player_Input_CM();

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        rbP = GetComponent<Rigidbody2D>();
        spP = GetComponent<SpriteRenderer>();
        ball = GameObject.FindGameObjectWithTag("Ball");
        startPos = transform.position;  
    }

    private void Update()
    {
        FlipPlayer();
        Jump();
        Walk();
        GroundCheck();
        HeadCheck();
        ShootAudio();
    }

    public void OnEnable()
    {
        playerInput.Enable();
    }

    public void OnDisable()
    {
        playerInput.Disable();
    }

    public void FixedUpdate()
    {
        //Laufen Input Code
        inWalk = playerInput.Movement.walk.ReadValue<Vector2>();

        //Springen Input Code
        inJump = playerInput.Movement.jump.ReadValue<float>();

        //Vertikal Schießen Input Code
        inShootV = playerInput.Movement.vShoot.ReadValue<float>();

        //Horizontal Schießen Input Code
        inShootH = playerInput.Movement.hShoot.ReadValue<float>();

    }

    private void FlipPlayer()
    {
        if (inWalk.x == -1)
        {
            spP.flipX = true;
        }

        if (inWalk.x == 1)
        {
            spP.flipX = false;
        }
    }

    private void Walk()
    {
        rbP.velocity = new Vector2(inWalk.x * speed * Time.deltaTime, rbP.velocity.y);
    }

    private void Jump()
    {
        if (inJump == 1 && grounded == true)
        {
            rbP.velocity = new Vector2(rbP.velocity.x, jumpHeight);
            jumpP = true;
        }
        else
        {
            jumpP = false;
        }
    }

    public bool isJumped() //for Sound -> GameManager
    {
        return jumpP;
    }

    private void ShootHorizontal()
    {
        if (inShootH == 1)
        {
            ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(addForce_x * inWalk.x, 0));
        }
    }

    private void ShootVertikal() 
    {
        if (inShootV == 1)
        {
            ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(addForce_x * inWalk.x, addForce_y));
        }
    }

    public bool isShot() //for Sound -> GameManager
    {
        return shootP;
    }

    private void ShootAudio()
    {
        if (colWithBall == true && (inShootH == 1 || inShootV == 1))
        {
            shootP = true;
        }
        else
        {
            shootP = false;
        }
    }

    private void GroundCheck()
    {
        grounded = Physics2D.OverlapCircle(groundCol.position, GroundOverlapRadius, ground_layer); 
    }

    private void HeadCheck()
    {
        headed = Physics2D.OverlapCircle(headCol.position, HeadOverlapRadius, ball_layer); 

        if(headed == true)
        {
            headValueX = addForceHead_x;
            headValueY = addForceHead_y;
            //Debug.Log("Head Collision");
            
        }
        else
        {
            headValueX = 0;
            headValueY = 0;
        }
        ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(headValueX * inWalk.x * Time.deltaTime, headValueY * Time.deltaTime));
    }
    

    public void SpawnPlayer()
    {
        transform.position = startPos;
        rbP.velocity = new Vector2(0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            ShootVertikal();
            ShootHorizontal();
            colWithBall = true;
        }
        else
        {
            colWithBall = false;
        }
    }
    
    
    
}
