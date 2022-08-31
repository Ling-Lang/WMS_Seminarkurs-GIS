using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
       player =GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null){
        player.GetComponent<Rigidbody2D>().bodyType=RigidbodyType2D.Static;
        player.GetComponent<SpriteRenderer>().enabled=false;
        player.GetComponent<Wincon>().enabled=false;
        player.GetComponent<GameOver>().enabled=false;
        player.GetComponent<Timer>().enabled=false;

        player.GetComponentInChildren<Camera>().enabled=false;
        player.GetComponentInChildren<AudioListener>().enabled=false;
        //player.transform.Find("UIZeug").gameObject.SetActive(false);
        


        }
    }
}
