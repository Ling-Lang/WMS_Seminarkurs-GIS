using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Szenewechsel : MonoBehaviour
{
    static bool created = false;

    public bool

            spawn = false,
            left_eg_trigger,
            right_eg_trigger,
            left_ug_trigger,
            right_ug_trigger;

    public bool

            eg_leftside = false,
            eg_rightside =false,
            ug_leftside = false,
            ug_rightside=false;

    public GameObject

            player,
            egleft,
            egright,
            ugleft,
            ugright;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        spawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        this.player = GameObject.Find("Player");
        ugleft = GameObject.Find("EG_Left");
        ugright = GameObject.Find("EG_Right");
        egleft = GameObject.Find("UG_Left");
        egright = GameObject.Find("UG_Right");

        


        if (spawn && left_eg_trigger&& !ug_leftside)
        {
            ug_leftside = true;
            ug_rightside = false;
        }
        if (spawn && right_eg_trigger && !ug_rightside)
        {
            ug_rightside = true;
            ug_leftside = false;
        }
        if (spawn && left_ug_trigger&& !eg_leftside)
        {
            eg_leftside = true;
            eg_rightside = false;
        }
        if (spawn && right_ug_trigger && !eg_rightside)
        {
            eg_rightside = true;
            eg_leftside = false;
        }

        /////////////////////////////////////////////////////////
        if (eg_leftside)
        {
            player.transform.position = ugleft.transform.position;
            eg_leftside = false;
        }
        if (eg_rightside)
        {
            player.transform.position = ugright.transform.position;
            eg_rightside = false;
        }
        if (ug_leftside)
        {
            player.transform.position = egleft.transform.position;
            ug_leftside = false;
        }
        if (ug_rightside)
        {
            player.transform.position = egright.transform.position;
            ug_rightside = false;
           
        }
        right_eg_trigger=false;
        left_eg_trigger=false;
        right_ug_trigger=false;
        left_ug_trigger=false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (
            col.gameObject.tag == "trigger" &&
            col.gameObject.name == "Left_Trigger"
        )
        {
            left_eg_trigger = true;
            SceneManager.LoadScene(3);
        }
        else
        {
            if (
                col.gameObject.tag == "trigger" &&
                col.gameObject.name == "Right_Trigger"
            )
            {
                right_eg_trigger = true;
                SceneManager.LoadScene(3);
            }
        }
        if (col.gameObject.tag == "trigger" && col.gameObject.name == "Left_UG")
        {
            left_ug_trigger = true;
            SceneManager.LoadScene(2);
        }
        else
        {
            if (
                col.gameObject.tag == "trigger" &&
                col.gameObject.name == "Right_UG"
            )
            {
                right_ug_trigger = true;
                SceneManager.LoadScene(2);
            }
        }
    }
}
