using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerMovment : MonoBehaviour
{
    public float speed = 4f;
    public float jumpForce = 10f;
    public float dashForce = 250f;
    public float dropForce = 10f;
    public float distToGnd = 10f;
    public float yDeadZone = .25f;
    private Vector2 movementVector;
    private Rigidbody2D myRigidbody;
    
    // Update is called once per frame
    void Update()
    {

        //Movement Stuff in x and y axis
        Vector3 currentPosition = transform.position;
        float controlHorizontal =Input.GetAxis("Horizontal");
        float deltaX = controlHorizontal * speed * Time.deltaTime;
        transform.position = new Vector3(
            currentPosition.x + deltaX,
            currentPosition.y,
            currentPosition.z);

        //Raycast stuff

        ///////////Drop/////////////////////////////////
        if (Input.GetAxis("Vertical")<=-yDeadZone)
        {
            Debug.Log("FALL! Vertical axis value:" + Input.GetAxis("Vertical"));
            myRigidbody = gameObject.GetComponent<Rigidbody2D>();
            if (myRigidbody != null)
            {
                myRigidbody.AddForce(new Vector2(0, -dropForce), ForceMode2D.Impulse);
            }
        }
        ///////////////JUMP//////////////////////////////
        bool isGnd = false;
        if (currentPosition.y <= -distToGnd)
        {
            Debug.Log("Is grounded");
            isGnd = true;
        }
        else
        {
            isGnd = false;
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button0) && isGnd == true)
        {
            


            Debug.Log("JUMP!");
            myRigidbody = gameObject.GetComponent<Rigidbody2D>();
            if (myRigidbody != null)
            {
                myRigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }
            
        }
        ////////////////////Light Hit////////////////////////////
        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            Debug.Log("X!");
            
        }
        ///////////////////////Heavy Hit/////////////////////////
        if (Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            Debug.Log("Y!");

        }
        //////////////////////////Dash///////////////////////////////////
        if (Input.GetKeyDown(KeyCode.Joystick1Button5))
        {
            if (myRigidbody != null)
            {
                myRigidbody.AddForce(new Vector2(deltaX * dashForce, 0), ForceMode2D.Impulse);
                Debug.Log("RB!");
            }
        }
    }
}
