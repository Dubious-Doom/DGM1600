using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody2D rigid;
	private Transform transform;
	public float speed;


	// Use this for initialization
	void Start () {
		rigid = this.GetComponent<Rigidbody2D> ();
		transform = this.GetComponent<Transform> ();
		speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			print ("Up");
			rigid.velocity = new Vector2 (0, speed);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			print ("Down");
			rigid.velocity = new Vector2 (0, -speed);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			print ("Right");
			rigid.velocity = new Vector2 (speed, 0);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			print ("Left");
			rigid.velocity = new Vector2 (-speed, 0);
		}

		if (Input.GetKey (KeyCode.UpArrow) && Input.GetKey (KeyCode.RightArrow)) {
			print ("Up and Right");
			rigid.velocity = new Vector2 (speed, speed);
		}

		if (Input.GetKey (KeyCode.DownArrow) && Input.GetKey (KeyCode.RightArrow)) {
			print ("Down and Right");
			rigid.velocity = new Vector2 (speed, -speed);
		}

		if (Input.GetKey (KeyCode.DownArrow) && Input.GetKey (KeyCode.LeftArrow)) {
			print ("Down and Left");
			rigid.velocity = new Vector2 (-speed, -speed);
		}

		if (Input.GetKey (KeyCode.UpArrow) && Input.GetKey (KeyCode.LeftArrow)) {
			print ("Up and Left");
			rigid.velocity = new Vector2 (-speed, speed);
		}
	}
}
