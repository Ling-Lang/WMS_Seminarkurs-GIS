using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class go_up : MonoBehaviour
{
    public GameObject player;
    public GameObject EG_Left;
    public GameObject EG_Right;
    public int x=0;
    public bool lor;
    private string ug_eg = @"Assets/Code/Code_JT/External_Var/eg_ug.jt";
   [SerializeField] private int array = 0;
    // Start is called before the first frame update
    
    void Start()
    {
        EG_Left = GameObject.Find("EG_Left");
        EG_Right = GameObject.Find("EG_Right");
        player = GameObject.FindGameObjectWithTag("Player");
        string [] lines = File.ReadAllLines(ug_eg);
        if(lines[x] == "0")
                {
                    player.transform.position = EG_Left.transform.position;
                }
         if (lines[x] == "1")
                {
                    player.transform.position = EG_Right.transform.position;
                }
    }   

    // Update is called once per frame
    void Update()
    {
    
    }
       void OnCollisionEnter2D(Collision2D col)
       {
           if(col.gameObject.tag == "trigger" && col.gameObject.name == "Left_UG")
           {
                string [] lines = File.ReadAllLines(ug_eg);
                lines[x]=lines[x].Replace("1","0");
                File.WriteAllLines(ug_eg,lines);
                Debug.Log(lines[x]);
                SceneManager.LoadScene(2);
                Debug.Log("Trigger1");
                
           }
           else
           {
            if(col.gameObject.tag == "trigger" && col.gameObject.name == "Right_UG")
            {
                string [] lines = File.ReadAllLines(ug_eg);
                lines[x]=lines[x].Replace("0","1");
                File.WriteAllLines(ug_eg,lines);
                Debug.Log(lines[x]);
                SceneManager.LoadScene(2);
                Debug.Log("Trigger2");

            }
           }
       }
        
    
 }

