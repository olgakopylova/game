using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public Vector2 speed = new Vector2 (50, 50);
	private Vector2 movement;
	public Rigidbody2D rb2D;

	void Start() {
		rb2D = GetComponent<Rigidbody2D>();
	}

	void Update () {
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");
		movement = new Vector2 (speed.x * inputX, speed.y * inputY);
	}

	void FixedUpdate(){
		rb2D.MovePosition(rb2D.position + movement);
	}
}
