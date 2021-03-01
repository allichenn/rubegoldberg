using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStart : MonoBehaviour
{

    SpriteRenderer myRenderer;
    public Color trigger1Color;
    //public Color gateColor;

    Rigidbody2D myBody;

    public float power;
    bool spacePressed;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        myBody = gameObject.GetComponent<Rigidbody2D>();
        spacePressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        //START HERE, AND CAN ONLY PRESS SPACE ONCE//
        if(spacePressed == false && Input.GetKeyDown(KeyCode.Space)){ //press down key once, returns true once
            //myBody.AddForce((Vector3.right + Vector3.up) * power);
            myBody.AddForce((new Vector3(-1, 0, 0) /*+ new Vector3(0, 1, 0)*/) * power);
            spacePressed = true;
        }
    }
}
