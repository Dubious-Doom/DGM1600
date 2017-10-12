using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour {
	public LevelManager myLevelManager;


	private void OnTriggerEnter2D (Collider2D trigger){
		myLevelManager.LevelLoad ("GameOver");
		print ("Collision");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
