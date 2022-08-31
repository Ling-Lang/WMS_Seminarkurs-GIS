using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Wake_Up : MonoBehaviour
{
    public AudioSource asource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void wake_up(){
        asource.Stop();
        SceneManager.LoadScene(0);
    }
    public void resume(){
        Time.timeScale = 1;
        //hello
    }
}
