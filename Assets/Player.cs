using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public int speed;
    bool touchingPlatform;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        ReadKeys();
    }


    void ReadKeys()
    {
        //rb.velocity = new Vector2(0, 0);

        if (Input.GetKeyDown("up") && touchingPlatform)
        {
            print("player pressed up");
            //transform position = new Vector2(transform.position.x, transform.position.y + (speedTime.deltaTime) );
            rb.velocity = new Vector2(0, 6);

        }

        if (Input.GetKey("right"))
        {
            rb.velocity = new Vector2(2, 0);
        }

        if (Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-2, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchingPlatform = true;
        }
    }


    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            touchingPlatform = false;
        }
    }

}



















