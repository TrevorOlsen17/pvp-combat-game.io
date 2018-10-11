using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBoatPurple : MonoBehaviour { 




   
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public KeyCode moveRight = KeyCode.D;
    public KeyCode moveLeft = KeyCode.A;

    public float speed = 5.0f;
    public float boundY = 20f;
    public float boundX = 20f;
    private Rigidbody2D rb2d;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var vel = rb2d.velocity;
        if (Input.GetKey(moveUp))
        {
            vel.y = speed;
        }
        else if (Input.GetKey(moveDown))
        {
            vel.y = -speed;
        }
        else
        {
            vel.y = 0;
        }
        rb2d.velocity = vel;

        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;







        var vell = rb2d.velocity;
        if (Input.GetKey(moveRight))
        {
            vell.x = speed;
        }
        else if (Input.GetKey(moveLeft))
        {
            vell.x = -speed;
        }
        else
        {
            vell.x = 0;
        }
        rb2d.velocity = vell;

        var pos2 = transform.position;
        if (pos2.x > boundX)
        {
            pos2.x = boundX;
        }
        else if (pos2.x < -boundX)
        {
            pos2.x = -boundX;
        }
        transform.position = pos2;




    }
}
