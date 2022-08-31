using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCandy : MonoBehaviour
{
    private bool collided;
    public Transform hcol;
    public float hor; //headoverlapradius

    void Update()
    {
        Debug.Log(hcol);

        if (collided == true )
        {
            Debug.Log("collided");
        }
    }
    private void collision()
    {
        collided = Physics2D.OverlapCircle(hcol.position, hor, LayerMask.GetMask("Candy"));
    }
   
}
