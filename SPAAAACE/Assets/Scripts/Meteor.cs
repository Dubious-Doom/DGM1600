using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

	public int health;

	public float startingSpin;

	public GameObject explosionEffect;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddTorque (Random.Range(-startingSpin, startingSpin), ForceMode2D.Impulse);
		health = Random.Range (5, 8);
	}

	public void OnCollisionEnter2D (Collision2D collider){
		print ("Meteor Collision");
		health--;

		if (health <= 0){
			Destroy(this.gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
		}
	}


		
	// Update is called once per frame
	void Update () {
		
	}
}
