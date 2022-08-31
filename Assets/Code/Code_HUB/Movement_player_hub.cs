using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.InputSystem;

public class Movement_player_hub : MonoBehaviour
{
    private InputAction_hub inputActions;
    private new Rigidbody2D rigidbody;
    public Animator animator;

   

    //Inputs
    private float inW, inD, inS, inA;
    private float walkX = 1, walkY = 1;

    private Vector2 movement, movement2;
    private Vector2 overNull;
    public int movementSpeed;

    private bool colPortF;
    private bool colPortC;
    private bool colPortB;
    private bool colPortH;

    public Transform portF;
    public Transform portC;
    public Transform portB;
    public Transform portH;

    public LayerMask player;
    private float Overlapradius = 9;

    public static Movement_player_hub Instance { get; private set; }

    private void Awake()
    {
        inputActions = new InputAction_hub();
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        inputActions.Museum.Move_C.performed += ctx => movement2 = ctx.ReadValue<Vector2>();
        inputActions.Museum.Move_C.canceled += ctx => movement2 = Vector2.zero;
    }


    public void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        overNull = new Vector2(0f, 0f);
       
    }

    private void Update()
    {
        Move();
        portCollision();
        
    }


    public void FixedUpdate()
    {
        inW = inputActions.Museum.W.ReadValue<float>();
        inD = inputActions.Museum.D.ReadValue<float>();
        inS = inputActions.Museum.S.ReadValue<float>();
        inA = inputActions.Museum.A.ReadValue<float>();
    }

    public void OnEnable()
    {
        inputActions.Museum.Enable();
    }

    public void OnDisable()
    {
        inputActions.Museum.Disable();
    }

    private void Move()
    {
        
        if (inD > 0 && inW == 0 && inS == 0 && inA == 0)//rechts
        {
            walkX = 1;
            walkY = 0;
        }

        if (inA > 0 && inW == 0 && inS == 0 && inD == 0)//links
        {
            walkX = -1;
            walkY = 0;
        }
        
        if (inW > 0 && inA == 0 && inS == 0 && inD == 0)//oben
        {
            walkX = 0;
            walkY = 1;
        }

        if (inS > 0 && inW == 0 && inA == 0 && inD == 0)//unten
        {
            walkX = 0;
            walkY = -1;
        }
        
        if (inD > 0 && inS > 0 && inA == 0 && inW == 0) //rechts runter
        {
            walkX = 1;
            walkY = -0.5f;
            animator.SetFloat("l_o", -1);

        }

        if (inD > 0 && inW > 0 && inA == 0 && inS == 0) //rechts hoch
        {
            walkX = 1;
            walkY = 0.5f;
            animator.SetFloat("l_o", 2);
            
        }

        if (inA > 0 && inS > 0 && inD == 0 && inW == 0) //links runter
        {
            walkX = -1;
            walkY = -0.5f;
            animator.SetFloat("l_u", -1);
        }

        if (inA > 0 && inW > 0 && inD == 0 && inS == 0) //links hoch
        {
            walkX = -1;
            walkY = 0.5f;
            animator.SetFloat("l_u", 2);
        }
        
        if (inS == 0 && inW == 0 && inA == 0 && inD == 0)//else
        {
            walkX = 0;
            walkY = 0;
            animator.SetFloat("l_u", walkX);
            animator.SetFloat("l_o", walkX);
        }

        movement.x = walkX;
        movement.y = walkY;
        if(movement2.x != overNull.x || movement2.y != overNull.y)//If no Controller Input, then Keyboard
        {
            rigidbody.MovePosition(rigidbody.position + movement2 * movementSpeed * Time.deltaTime);
        }
        else
        {
            rigidbody.MovePosition(rigidbody.position + movement * movementSpeed * Time.deltaTime);
            //^ Steuerung mit dem Controller
        } 
    }

    private void portCollision()
    {
        colPortF = Physics2D.OverlapCircle(portF.position, Overlapradius, player);
        colPortC = Physics2D.OverlapCircle(portC.position, Overlapradius, player);
        colPortH = Physics2D.OverlapCircle(portH.position, Overlapradius, player);
        colPortB = Physics2D.OverlapCircle(portB.position, Overlapradius, player);
    }
    

    public bool gibCollisionFootball()
    {
        return colPortF;
    }

    public bool gibCollisionCandy()
    {
        return colPortC;
    }

    public bool gibCollisionHitler()
    {
        return colPortH;
    }

    public bool gibCollisionBallon()
    {
        return colPortB;
    }


}
