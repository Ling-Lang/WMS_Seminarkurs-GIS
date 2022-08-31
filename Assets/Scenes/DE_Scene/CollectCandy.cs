using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectCandy : MonoBehaviour
{

        public int punkte = 0;
        public TMP_Text punkteText;
        public Input_DE Player;
        

    public void DecreaseMovement()
    {
        Player.movementSpeed= Player.movementSpeed-3;
    }
    
        public void OnTriggerEnter2D(Collider2D col)
        {
        Debug.Log("GameObject2 collided with " + col.name);


        
        if (col.gameObject.tag == "Enemy")
            {
            
            
                punkte+=1;
                punkteText.text ="Points: " + punkte.ToString();
                Destroy(GameObject.Find("Candy(Clone)"));
                
                

        }
        else if(col.gameObject.tag == "Apple")
        {
            punkte += 1;
            punkteText.text = "Points: " + punkte.ToString();
            Destroy(GameObject.Find("Apple(Clone)"));
            Player.movementSpeed= Player.movementSpeed+3;
            Invoke("DecreaseMovement", 5);
        }

        
        }



}
