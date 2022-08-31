using UnityEngine;

public class Input_DE : MonoBehaviour
{
    public float movementSpeed = 1;
    public float jumpForce = 1;
    public Rigidbody2D rb;
    public bool isGrounded;
    //public Vector2 movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionStay2D()
    {
        isGrounded = true;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }
    //Called  50/sec by Default not tied to fps = good
    private void FixedUpdate()
    {
        // Movement
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        if(!Mathf.Approximately(0, movement))
        {
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

        // Jump


    }
}
