using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4f;
    public float jumpForce = 6f;
    public bool direction = false;

    public Animator anim;

    void Start()
    {
        if(anim == null)
        {
            anim = gameObject.GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 currentPosition = transform.position;
        float deltaX = (horizontalInput * speed * Time.deltaTime);
        transform.position = new Vector3(
            currentPosition.x + deltaX,
            currentPosition.y,
            currentPosition.z);

        anim.SetFloat("Hspeed", Mathf.Abs(horizontalInput));
        if(Mathf.Abs(horizontalInput)>0)
        {
            if (horizontalInput > 0)
            {
                //Debug.Log("Leftwards");
                transform.localScale = new Vector3(-1, 1, 1);
                //transform.localScale = new Vector3(-1, 1, 1);
            }
            else if(horizontalInput < 0)
            {
                //Debug.Log("Rightwards");
                transform.localScale = new Vector3(1, 1, 1);
            }

        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("FALL!");
            Rigidbody2D myRigidbody = gameObject.GetComponent<Rigidbody2D>();
            if (myRigidbody != null)
            {
                myRigidbody.AddForce(new Vector2(0, -jumpForce * .045f), ForceMode2D.Impulse);
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("JUMP!");
            Rigidbody2D myRigidbody = gameObject.GetComponent<Rigidbody2D>();
            if (myRigidbody != null)
            {
                myRigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("PUNCH!");
            if (anim != null)
            {
                anim.SetTrigger("PunchRight");
            }
            

        }

        //if (Input.GetKey(KeyCode.A))
        //{
        //    if (anim != null)
        //    {
        //        anim.SetTrigger("WalkRight");
        //    }
        //    // direction = false; //false = right
        //}

        //if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.Space))
        //{
        //    if (anim != null)
        //    {
        //        anim.SetTrigger("WalkRight");
        //    }
        //    //direction = false;
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    Debug.Log("LEFT!");
        //    if (anim != null)
        //    {
        //        anim.SetTrigger("WalkLeft");
        //    }
        //    //direction = true; //true = left
        //}

        //    if (!direction)
        //    {
        //        if (anim != null)
        //        {
        //            anim.SetTrigger("Idle");
        //        }
        //    }

        //    if (direction)
        //    {
        //        if (anim != null)
        //        {
        //            anim.SetTrigger("IdleLeft");
        //        }
        //    }
        //}
    }
}