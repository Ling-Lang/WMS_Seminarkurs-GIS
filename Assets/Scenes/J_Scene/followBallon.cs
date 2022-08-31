using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followBallon : MonoBehaviour
{

    public GameObject Camera, Ballon;
    

    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("Camera");
        Ballon = GameObject.Find("Ballon");
    }

    // Update is called once per frame
    void Update()
    {
        Camera.transform.position = new Vector3(Ballon.transform.position.x, Ballon.transform.position.y, Camera.transform.position.z);
    }
}
