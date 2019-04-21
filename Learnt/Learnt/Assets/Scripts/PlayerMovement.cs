using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4f;
    public float jumpForce = 10f;
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

        if (Input.GetKey(KeyCode.S) )
        {
            Debug.Log("FALL!");
            Rigidbody2D myRigidbody = gameObject.GetComponent<Rigidbody2D>();
            if (myRigidbody != null)
            {
                myRigidbody.AddForce(new Vector2(0, -jumpForce), ForceMode2D.Impulse);
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
    }
}