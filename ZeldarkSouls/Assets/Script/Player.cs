using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject GOPlayer;
    public float speed = 100;
    private Vector2 directionUp = new Vector2(0, 1);
    private Vector2 directionLeft = new Vector2(1, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Base déplacement du joueur
        if(Input.GetKey("up"))
        {
            GOPlayer.transform.Translate(directionUp * speed * Time.deltaTime);                      
        }

        if(Input.GetKey("down"))
        {
            GOPlayer.transform.Translate(-directionUp * speed * Time.deltaTime);
        }

        if (Input.GetKey("left"))
        {
            GOPlayer.transform.Translate(-directionLeft * speed * Time.deltaTime);
        }

        if (Input.GetKey("right"))
        {
            GOPlayer.transform.Translate(directionLeft * speed * Time.deltaTime);
        }

       
    }
}
