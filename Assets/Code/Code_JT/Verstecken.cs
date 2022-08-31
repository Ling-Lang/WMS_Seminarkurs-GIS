using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Verstecken : MonoBehaviour
{
   
    public GameObject Player;
    public GameObject Shelf;
    private Rigidbody2D OldRb;

    private Collider2D PlayerCollider, ShelfCollider;
    private SpriteRenderer PlayerSprite, ShelfSprite;
    public bool PlayerIsHidden = false;
    [SerializeField] private Sprite ShelfOpen, ShelfClosed;
    private Vector2 PlayerPosition;
    
    

    // Start is called before the first frame update
    void Start()
    {
      Player = GameObject.Find("Player");
      PlayerIsHidden = false;
      PlayerCollider = Player.GetComponent<Collider2D>();
        ShelfCollider = Shelf.GetComponent<Collider2D>();
        PlayerSprite = Player.GetComponent<SpriteRenderer>();
        ShelfSprite = Shelf.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame

   
    void Update()
    {
      if(PlayerIsHidden)
      {
        ShelfSprite.sprite = ShelfClosed;
      }
      else
      {
        ShelfSprite.sprite = ShelfOpen;
      }
      // if player is touching the shelf and pressing e then player collider is disabled
        if (PlayerCollider.IsTouching(ShelfCollider)&& (Input.GetKeyDown(KeyCode.F)||Input.GetButtonDown("Controller Verstecken"))&& !PlayerIsHidden)
        {
          Versteck();
        }         
        if (PlayerIsHidden&& (Input.GetKeyDown(KeyCode.R)||Input.GetButtonDown("Controller Enthuellen")))
        {
          Enthuellen();
        }
        if(Input.GetButtonDown("Controller Menu"))
        {
          GameObject.Find("UIZeug").transform.Find("Panel").transform.Find("Back").GetComponent<Button>().Select();
          GameObject.Find("pauseButton").GetComponent<Button>().onClick.Invoke();
        }

        
    }


    private void Versteck()
    {
      Debug.Log("Verstecken");
        Player.GetComponent<Collider2D>().enabled = false;
        PlayerSprite.enabled = false;
        OldRb = Player.GetComponent<Rigidbody2D>();
        Player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        PlayerPosition= Player.transform.position;
        PlayerIsHidden = true;
        

    }
    private void Enthuellen()
    {
     
        PlayerCollider.enabled = true;
        PlayerSprite.enabled = true;
        Player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        PlayerIsHidden = false;
        Player.transform.position = PlayerPosition;
        Debug.Log("Enthuellen");
    }   
}
       

  