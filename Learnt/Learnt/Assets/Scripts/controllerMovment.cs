using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerMovment : MonoBehaviour
{
    public float speed = 4f;
    public float jumpForce = 10f;
    private Vector2 movementVector;
    
    // Update is called once per frame
    void Update()
    {

        Vector3 currentPosition = transform.position;

        float controlHorizontal =Input.GetAxis("Horizontal");
        float deltaX = controlHorizontal * speed * Time.deltaTime;

        transform.position = new Vector3(
            currentPosition.x + deltaX,
            currentPosition.y,
            currentPosition.z);

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("FALL!");
            Rigidbody2D myRigidbody = gameObject.GetComponent<Rigidbody2D>();
            if (myRigidbody != null)
            {
                myRigidbody.AddForce(new Vector2(0, -jumpForce), ForceMode2D.Impulse);
            }
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            Debug.Log("JUMP!");
            Rigidbody2D myRigidbody = gameObject.GetComponent<Rigidbody2D>();
            if (myRigidbody != null)
            {
                myRigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            Debug.Log("X!");
            
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            Debug.Log("Y!");

        }
    }
}
