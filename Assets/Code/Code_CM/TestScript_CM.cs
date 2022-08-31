using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestScript_CM : MonoBehaviour
{
    public static TestScript_CM Instance;

    [SerializeField] private float walkSpeed;
    [SerializeField] private float jumpSpeed;
    private Player_Input_CM playerInput;
    private float movementInput;

    [SerializeField] private Rigidbody2D rb;


    private void Awake()
    {
        Instance = this;

        playerInput = new Player_Input_CM();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        
        playerInput.Enable();
        playerInput.Movement.jump.performed += DoJump; 
    }

    private void OnDisable()
    {
        playerInput.Disable();
        playerInput.Movement.jump.Disable();
    }

    //Spieler springt (braucht nicht in Update weil nur performed bei Taste)
    private void DoJump(InputAction.CallbackContext obj)
    {
        
        Vector3 currentPosition = transform.position;
        currentPosition.y += jumpSpeed * Time.deltaTime;
        transform.position = currentPosition;
    }

    private void Update() // Zu fixed aendern wegen fps abhaengigkeit
    {
        // Input lesen
        movementInput = playerInput.Movement.walk.ReadValue<float>(); //walk gibt es nicht mehr

        // Spieler bewegen
        //Vector3 currentPosition = transform.position;
        //currentPosition.x += movementInput * walkSpeed * Time.deltaTime;
        //transform.position = currentPosition;

        // anderer Code zum Bewegen des Spielers, damit die velocity einen Wert bekommt für Flip..
        //rb.velocity = new Vector2(movementInput * walkSpeed * Time.deltaTime, rb.velocity.y);
        // movement.x = Input.GetAxisRaw("Horizontal");
        // movement.y = Input.GetAxisRaw("Vertical");
    }

    public bool zeitAbgelaufen()
    {

        /*if (currentTime <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }*/
        return true;

    }

}
