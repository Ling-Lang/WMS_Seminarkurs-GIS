using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class change_scene : MonoBehaviour
{
    public GameObject player;
    public GameObject UG_Left;
    public GameObject UG_Right;
    public int lor, x = 1;
    private string eg_ug = @"Assets/Code/Code_JT/External_Var/eg_ug.jt";
    [SerializeField] private int array = 0;
    // Start is called before the first frame update
    void Start()
    {
        UG_Left = GameObject.Find("UG_Left");
        UG_Right = GameObject.Find("UG_Right");
        player = GameObject.FindGameObjectWithTag("Player");
        string[] lines = File.ReadAllLines(eg_ug);
        if (lines[x] == "0")
        {
            player.transform.position = UG_Left.transform.position;
        }
        if (lines[x] == "1")
        {
            player.transform.position = UG_Right.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /* string [] lines = File.ReadAllLines(eg_ug);
         if(lines[x] == "0")
         {
         Debug.Log(lines[x] + "it works");

         }*/
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "trigger" && col.gameObject.name == "Left_Trigger")
        {
            string[] lines = File.ReadAllLines(eg_ug);
            lines[x] = lines[x].Replace("1", "0");
            File.WriteAllLines(eg_ug,lines);
            Debug.Log(lines[x]);
            SceneManager.LoadScene(3);

        }
        else
        {
            if (col.gameObject.tag == "trigger" && col.gameObject.name == "Right_Trigger")
            {
                string[] lines = File.ReadAllLines(eg_ug);
                lines[x] = lines[x].Replace("0", "1");
                File.WriteAllLines(eg_ug,lines);
                Debug.Log(lines[x]);
                SceneManager.LoadScene(3);


            }
        }

    }
}
