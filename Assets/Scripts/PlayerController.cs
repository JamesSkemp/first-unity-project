using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	// As a public variable will show up in the editor as a field.
	public float speed;

	private Rigidbody2D rb2d;

	private void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		// Grabs cursor keys from keyboard.
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector2 movement = new Vector2(moveHorizontal, moveVertical);

		rb2d.AddForce(movement * speed);
	}
}
