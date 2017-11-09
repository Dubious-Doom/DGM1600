using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

	public int health;

	public float startingSpin;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddTorque (Random.Range(-startingSpin, startingSpin), ForceMode2D.Impulse);
		health = Random.Range (5, 8);
	}

	public void OnCollisionEnter2D (Collision2D collider){
		print ("Meteor Collision");
		health--;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
