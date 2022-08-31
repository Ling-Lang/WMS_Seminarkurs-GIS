using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Pathfinding;

public class Enemy_AI : MonoBehaviour
{
    public Transform Waypoint1, Waypoint2;
    public GameObject player;
    public float speed =200f;
    public float nextWaypointDistance= 3f;
    
    public Transform enemyGFX;

    public bool PlayerInView = false;
    public bool Waypoint1goal = false;
    public bool Waypoint2goal = false;

 [SerializeField] private Sprite upSprite, downSprite, leftSprite, rightSprite;


  
    Path path;
    int currentWaypoint =0;
    bool reachedEndOfPath=false;
    
    Seeker seeker;
       [SerializeField] private SpriteRenderer sr;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.Find("Player");
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        Waypoint2goal=true;
        Waypoint1goal=false;
        InvokeRepeating("UpdatePath", 0f, .5f); 
        sr = GetComponent<SpriteRenderer>();
       
    }


    void UpdatePath()
    {
      if(PlayerInView)
      {
        if (seeker.IsDone())
        {

            seeker.StartPath(rb.position, player.transform.position, OnPathComplete);

          }
      }
      
       if (!PlayerInView&&Waypoint2goal&&!Waypoint1goal)
        {
            if(seeker.IsDone())
            {
                seeker.StartPath(rb.position, Waypoint1.position, OnPathComplete);
                //Debug.Log("Path Updated1");
            }
            
        }
      if(!PlayerInView&&Waypoint1goal&&!Waypoint2goal)
        {
            if (seeker.IsDone())
            {
                seeker.StartPath(rb.position, Waypoint2.position, OnPathComplete);
               // Debug.Log("Path Updated2");
            }
        }
        if(Waypoint2goal)
       {
        Waypoint1Check();
       }
       if(Waypoint1goal)
       {
        Waypoint2Check();
       }
     
        
    }
          


    

    void OnPathComplete(Path p)
    {
       if(!p.error)
       {
         path = p;
         currentWaypoint = 0;
       }
       return;

       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       PlayerCheck();
       
      // UpdatePath();

       
       if(path == null)
       {
          return;
       }
       if(currentWaypoint >= path.vectorPath.Count)
       {
          reachedEndOfPath = true;
          return;
        }
        else
        {
          reachedEndOfPath = false;
        }
     
      Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
      Vector2 force = direction * speed * Time.deltaTime;
      
      //Old Code
      //rb.AddForce(force);
      /// ////////////////////////////////////////////////////////////////////////////////////////////////
      rb.MovePosition(rb.position + direction * speed * Time.deltaTime);
      if (direction.x > 0)
        {
            sr.sprite = rightSprite;
        }
        else if (direction.x < 0)
        {
            sr.sprite = leftSprite;
        }
        else if (direction.y > 0)
        {
            sr.sprite = upSprite;
        }
        else if (direction.y < 0)
        {
            sr.sprite = downSprite;

        }

      float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);
      
      if(distance < nextWaypointDistance)
      {
        currentWaypoint++;
      }

      
    }
     private void PlayerCheck()
      {
        PlayerInView= Physics2D.OverlapCircle(enemyGFX.position, 4f, LayerMask.GetMask("Player"));
      }
      private void Waypoint1Check()
      {
        Waypoint1goal= Physics2D.OverlapCircle(enemyGFX.position, 0.1f, LayerMask.GetMask("Waypoint1"));
        //Debug.Log("Waypoint1goal: "+Waypoint1goal);
      }

      private void Waypoint2Check()
      {
        Waypoint2goal= Physics2D.OverlapCircle(enemyGFX.position, 0.1f, LayerMask.GetMask("Waypoint2"));
        //Debug.Log("Waypoint2goal: "+Waypoint2goal);
      }
    }

  

