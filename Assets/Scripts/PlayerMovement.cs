﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // this is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    public float forwardForce = 1200f;
    public float sidewaysForce = 500f;

	
	// We marked this as "Fixed"Update because we are using it 
    // to mess with physics
	void FixedUpdate ()
    {
        //add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);	

        if (Input.GetKey("d"))
        {
            //add a force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            //add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
