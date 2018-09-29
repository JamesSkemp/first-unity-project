using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	// As a public variable will show up in the editor as a field.
	public float speed;
	public Text countText;

	private Rigidbody2D rb2d;
	private int count;

	private void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		count = 0;
		setCountText();
	}

	private void FixedUpdate()
	{
		// Grabs cursor keys from keyboard.
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector2 movement = new Vector2(moveHorizontal, moveVertical);

		rb2d.AddForce(movement * speed);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("PickUp")) {
			collision.gameObject.SetActive(false);
			count++;
			setCountText();
		}
	}

	private void setCountText() {
		countText.text = "Count: " + count.ToString();
	}
}
