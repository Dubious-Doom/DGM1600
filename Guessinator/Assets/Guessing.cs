using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guessing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Welcome to Number Guesser");
		print ("Pick a number in your head");

		print ("The highest number you can pick is 100");
		print ("The lowest number you can pick is 1");

		print ("Is the number higher or lower than 50?");
		print ("Up arrow for higher, Down for lower, Enter for equal");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			print ("fun stuff");
			print ("other stuff");
		}
	}
}