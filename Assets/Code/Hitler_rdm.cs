using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hitler_rdm : MonoBehaviour
{
    public Transform Hitler;
    private GameObject Z1,Z2,Z3,Z4,Z5,Z6;
    public int rd;

    // Start is called before the first frame update
    void Start()
    {
        Z1=GameObject.Find("Zimmer 1");
        Z2=GameObject.Find("Zimmer 2");
        Z3=GameObject.Find("Zimmer 3");
        Z4=GameObject.Find("Zimmer 4");
        Z4=GameObject.Find("Zimmer 5");
        Z4=GameObject.Find("Zimmer 6");
        
        Hitler=GetComponent<Transform>();

        //random int genarator
        rd= Random.Range(1,7);
    }

    // Update is called once per frame
    void Update()
    {
        Zz(rd);
        
    }
    private void Zz( int rnd){
         switch(rnd)
        {
            case 1:
            Hitler.position=Z1.transform.position;
            break;
            case 2:
            Hitler.position=Z2.transform.position;
            break;
            case 3:
            Hitler.position=Z3.transform.position;
            break;
            case 4:
            Hitler.position=Z4.transform.position;
            break;
            case 5:
            Hitler.position=Z5.transform.position;
            break;
            case 6:
            Hitler.position=Z6.transform.position;
            break;
        }
    }
}
