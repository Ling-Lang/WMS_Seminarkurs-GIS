using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    public string ID;
    public static CandyScript instance;
    void Awake()
    {
        instance = this;
    }
    
    
    

}
