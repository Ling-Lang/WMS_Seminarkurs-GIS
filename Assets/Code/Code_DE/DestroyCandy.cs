using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCandy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy") 
        {

       Destroy(GameObject.Find("Candy(Clone)"));

        }
        else if (other.gameObject.tag == "Apple")
        {

            Destroy(GameObject.Find("Apple(Clone)"));

        }

    }


}
