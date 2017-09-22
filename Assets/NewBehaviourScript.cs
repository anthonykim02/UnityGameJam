using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public int playerSpeed = 10;
	private bool facingRight = false;
	public int playerJumpPower = 1250;
	private float moveX;
	private float moveY;

	// Update is called once per frame
	void Update () {
		PlayerMove ();

		if (Input.GetKeyDown(KeyCode.Z)) {
			Ability1 ();
		}

		if (Input.GetKeyDown(KeyCode.X)) {
			Ability2 ();
		}

		if (Input.GetKeyDown(KeyCode.C)) {
			Ability3 ();
		}

	}

	void PlayerMove() {
		moveX = Input.GetAxis ("Horizontal");
		moveY = Input.GetAxis ("Vertical");
//		if (Input.GetButtonDown ("Jump")) {
//			Jump ();
//		}


		if (moveX < 0.0f && facingRight == false) {
			FlipPlayerHoriz ();
		} else if (moveX > 0.0f && facingRight == true) {
			FlipPlayerHoriz ();
		}

		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (gameObject.GetComponent<Rigidbody2D>().velocity.x, moveY * playerSpeed);

	}

	void Ability1() {
		print ("ability 1");
	}

	void Ability2() {
		print ("ability 2");
	}

	void Ability3() {
		print ("ability 3");
	}



	void FlipPlayerHoriz() {
		facingRight = !facingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}
}
