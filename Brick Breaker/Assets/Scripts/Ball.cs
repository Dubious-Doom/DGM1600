using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public GameObject paddle;


	//A bool used to initiate play
	private bool playing = false;

	//Distance from ball to paddle
	private Vector3 paddleToBallVector;
	//Rigidbody2D handler variable
	private Rigidbody2D rigid;

	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
		rigid = this.GetComponent<Rigidbody2D> ();
	}

	void Update () {

		if (!playing) {
			//Update object position according to paddle position plus the offset vector
			this.transform.position = paddle.transform.position + paddleToBallVector;

			//if push start button
			if(Input.GetMouseButtonDown(0)){
				//ball goes flying
				rigid.velocity = new Vector2 (15, 25);
				//playing = true;
				print ("pushed mouse");
				playing = true;
			}
		}



	}
}
