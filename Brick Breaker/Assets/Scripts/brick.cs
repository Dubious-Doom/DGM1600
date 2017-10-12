using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour {

	public int Health = 3;

	public void OnCollisionEnter2D (Collision2D collider){
		Health --;
		print ("Collision");

		if(Health == 0){
			Destroy(this);
		}
	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
