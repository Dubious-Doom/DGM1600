using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meteor : MonoBehaviour {

	public int health;

	public float startingSpin;

	public GameObject explosionEffect;

	public Text scoreBoard;

	public Scoreboard scoreScript;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddTorque (Random.Range(-startingSpin, startingSpin), ForceMode2D.Impulse);
		health = Random.Range (5, 8);
		scoreScript = FindObjectOfType<Scoreboard> ();
	}

	public void OnCollisionEnter2D (Collision2D collider){
		print ("Meteor Collision");
		health--;

		if (health <= 0){
			Destroy(this.gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
			IncrementScore ();

		}
	}

	public int GetHealth(){
		//fun code

		return health;
	}


		
	// Update is called once per frame
	void Update () {
		
	}

	private void IncrementScore(){
		//scoreBoard.GetComponent<Scoreboard>().IncrementScoreboard(10);
		scoreScript.IncrementScoreboard(10);
	}
}
