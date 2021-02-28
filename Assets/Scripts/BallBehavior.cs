using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{

    SpriteRenderer myRenderer;
    public Color floorColor;
    public Color gateColor;

    Rigidbody2D myBody;

    public float power;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        myBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){ //press down key once, returns true once
            //myBody.AddForce((Vector3.right + Vector3.up) * power);
            myBody.AddForce((new Vector3(1, 0, 0) + new Vector3(0, 1, 0)) * power);
        }
    }

    void OnCollisionEnter2D(Collision2D other){ //other is whatever the heck it collided into
        if(other.gameObject.name == "square"){ //must be double ==
            myRenderer.color = floorColor;
            Debug.Log("Hit floor");
        }
    }

    void OnTriggerEnter2D(Collider2D other){ //COLLIDER not COLLISION bc no physics
        if(other.gameObject.name == "gate"){ //must be double ==
            myRenderer.color = gateColor;
            Debug.Log("Hit gate");
        }

    }
}
