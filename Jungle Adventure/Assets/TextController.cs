using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text SuperText;

	public enum States {entrance, door, easternPath, southernPath, westernPath};
	public States playerState;
	public bool someValue = true;


	// Use this for initialization
	void Start () {
		playerState = States.entrance;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerState == States.entrance) {State_entrance ();}
		if (playerState == States.door) {State_door ();}
		if (playerState == States.easternPath) {State_easternPath ();}
		if (playerState == States.southernPath) {State_southernPath ();}
		if (playerState == States.westernPath) {State_westernPath ();}
	}

	void State_entrance(){
		SuperText.text = "You find yourself in a jungle clearing. To the north is a massive stone temple. There are mysterious paths that lead east, south, and west. " +
			"\n\nWhich way will you go?" + 
			"\n\nUse the Arrow Keys to navigate North, South, East, or West.";

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			playerState = States.door;
		} 
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			playerState = States.southernPath;
		}
		else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			playerState = States.easternPath;
		}
		else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			playerState = States.westernPath;
		}
	}

	void State_door(){
		SuperText.text = "The door to the temple is sealed shut. " +
			"\nThere are three oddly shaped holes to the side of the door. " +
			"\nKey holes perhaps? But where are the keys?" +
			"\n\nYou can head back to the Temple Entrance.";
	}

	void State_easternPath(){
		SuperText.text = "east";
	}

	void State_southernPath(){
		SuperText.text = "south";
	}

	void State_westernPath(){
		SuperText.text = "west";
	}
}
