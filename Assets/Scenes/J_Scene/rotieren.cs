using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotieren : MonoBehaviour
{
    private float rotZ = 0;
    public float rotationSpeed;
    public bool clockwiseRotation;

    // Update is called once per frame
    void Update()
    { 
       if(clockwiseRotation == false)
       {
           rotZ += Time.deltaTime * rotationSpeed;
       }
       else
       {
           rotZ += -Time.deltaTime * rotationSpeed;
       }

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
