using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float lifetime;
	public float speed;


	// Use this for initialization
	void Start () {
		
	}

	public void OnCollisionEnter2D (Collision2D collider){
		print ("Projectile Collision");
		Destroy (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		//This causes lifetime to decrement in realtime instead of based on clock cycles
		lifetime -= Time.deltaTime;


		if (lifetime <= 0) {
			Destroy (this.gameObject);
		}


		transform.Translate (Vector3.up * speed * Time.deltaTime);

	
	}
}
