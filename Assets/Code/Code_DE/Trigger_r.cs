using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_r : MonoBehaviour
{
    public Plane_DE plane;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Placeholder_Plane")
        {
            plane.direction = false;
        }



    }
}
