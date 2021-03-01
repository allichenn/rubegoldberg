using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartColor : MonoBehaviour
{

    SpriteRenderer myRenderer;
    //public Color trigger1Color;
    public Color heartsColor;

    Rigidbody2D myBody;

    public float power;
    //bool spacePressed;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        myBody = gameObject.GetComponent<Rigidbody2D>();
        //spacePressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        //START HERE, AND CAN ONLY PRESS SPACE ONCE//
        /*if(spacePressed == false && Input.GetKeyDown(KeyCode.Space)){ //press down key once, returns true once
            //myBody.AddForce((Vector3.right + Vector3.up) * power);
            myBody.AddForce((new Vector3(1, 0, 0) + new Vector3(0, 1, 0)) * power);
            spacePressed = true;
        }*/
    }

    /*void OnCollisionEnter2D(Collision2D other){ //other is whatever the heck it collided into
        if(other.gameObject.name == "trigger1"){ //must be double ==
            myRenderer.color = trigger1Color;
            Debug.Log("hit trigger 1");
        }
    }*/

    void OnTriggerEnter2D(Collider2D other){ //COLLIDER not COLLISION bc no physics
        if(other.gameObject.name == "ball"){ //must be double ==
            myRenderer.color = heartsColor;
            Debug.Log("Hit gate");
        }

    }
}
