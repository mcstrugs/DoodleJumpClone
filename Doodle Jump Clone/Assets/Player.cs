using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

    private Rigidbody2D rb;
    private float movement = 0f;

    public float movementSpeed = 10f;
	
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
		Vector2 position = rb.position;
		if(rb.position.x < -4f)
		{
			position.x = 4f;
		}
		if(transform.position.x > 4f)
		{
			position.x = -4f;
		}
		rb.position = position;
	}

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
