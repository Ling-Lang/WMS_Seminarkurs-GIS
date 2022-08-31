using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Test_Code_CM : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Es funktioniert, Nice und es hat keine Fehler mehr");
    }

    void Update()
    {
        Keyboard kb = InputSystem.GetDevice<Keyboard>();
        if (kb.spaceKey.wasPressedThisFrame)
        {
            //Debug.Log("Someone pressed space?!");
        }
    }

    public void PlayCM()
    {
        SceneManager.LoadScene("Game_CM");
    }
}
