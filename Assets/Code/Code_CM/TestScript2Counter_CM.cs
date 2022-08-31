using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2Counter_CM : MonoBehaviour
{

    public static TestScript2Counter_CM Instance;

    public void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
