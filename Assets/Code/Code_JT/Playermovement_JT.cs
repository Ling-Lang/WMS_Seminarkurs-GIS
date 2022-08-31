using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement_JT : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Rigidbody2D rb;
    private Collider2D col;
    public Vector2 movement;
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Sprite upSprite, downSprite, leftSprite, rightSprite;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
        rb = this.GetComponent<Rigidbody2D>();
        sr = this.GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame Dependent on Framerate = Bad 
    void Update()
    {
       // Input 
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");
    }

    //Called  50/sec by Default not tied to fps = good
    void FixedUpdate()
    {
        // Movement ermöglicht solange wie die Kollisionen aktiv sind
        if(col.enabled)
        {
            rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
        }
        //Rotates the player to face the direction of movement
        if (movement.x > 0)
        {
            sr.sprite = rightSprite;
        }
        else if (movement.x < 0)
        {
            sr.sprite = leftSprite;
        }
        else if (movement.y > 0)
        {
            sr.sprite = upSprite;
        }
        else if (movement.y < 0)
        {
            sr.sprite = downSprite;

        }
    }
}
