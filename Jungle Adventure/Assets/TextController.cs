using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text SuperText;

	public enum States {entrance, door, easternPath, southernPath, westernPath, death, east_01, east_02, south_01, west_01, west_02, templeInterior};
	public States playerState;
	public bool someValue = true;
	public bool redStone = false;
	public bool blueStone = false;
	public bool greenStone = false;
	public bool grapplingHook = false;
	public bool snakeFlute = false;


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
		if (playerState == States.death) {State_death ();}
		if (playerState == States.east_01) {State_east_01 ();}
		if (playerState == States.east_02) {State_east_02 ();}
		if (playerState == States.south_01) {State_south_01 ();}
		if (playerState == States.west_01) {State_west_01 ();}
		if (playerState == States.west_02) {State_west_02 ();}
		if (playerState == States.templeInterior) {State_templeInterior ();}
	}

	void State_entrance(){
		SuperText.text = "You find yourself in a jungle clearing. To the North is a massive stone temple. There are mysterious paths that lead East, South, and West. " +
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
		if (redStone == true && blueStone == true && greenStone == true) {
			SuperText.text = "The three colorful stones magically fly into the key holes." +
			"\n The door opens, dust cascading down as the stone heaves." +
			"\n\n Enter with Enter.";

			if (Input.GetKeyDown (KeyCode.Return)) {
				playerState = States.templeInterior;
			}
		}

		else if (redStone == false || blueStone == false || greenStone == false) {
		SuperText.text = "The door to the temple is sealed shut. " +
			"\nThere are three oddly shaped holes to the side of the door. " +
			"\nKey holes perhaps? But where are the keys?" +
			"\n\nYou can head back South to the temple entrance.";

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			playerState = States.entrance;
		}
		}
	}

	void State_easternPath(){
		SuperText.text = "You set off down the eastern path." +
			"\nThe road forks to the North and South. You can also go West to return to the temple entrance." +
			"\n\nWhich road will you take?";
		
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			playerState = States.east_01;
		} 

		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			playerState = States.east_02;
		}

		else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			playerState = States.entrance;
		}
	}

	void State_southernPath(){
		SuperText.text = "A sign reads:" +
			"\n\"Turn back, unless you possess the red and blue stones.\"" +
			"\n\nThe way forward is dark and spooky. Maybe find those stones if you haven't already." +
			"\nGo North to return to the temple entrance, or press Enter to try the path.";

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			playerState = States.entrance;
		}

		else if (Input.GetKeyDown (KeyCode.Return)) {
			playerState = States.south_01;
		}


	}

	void State_westernPath(){
		SuperText.text = "You set off down the western path." +
			"\nThe road forks to the North and South. You can also go East to return to the temple entrance." +
			"\n\nWhich road will you take?";

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			playerState = States.west_01;
		} 

		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			playerState = States.west_02;
		}

		else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			playerState = States.entrance;
		}
	}

	void State_death(){
		SuperText.text = "You are now thoroughly dead." +
			"\nWhoops." +
			"\n\nPress R to Retry.";

		redStone = false;
		blueStone = false;
		greenStone = false;
		grapplingHook = false;
		snakeFlute = false;

		if (Input.GetKeyDown (KeyCode.R)) {
			playerState = States.entrance;
		} 	
	}

	void State_east_01(){
		SuperText.text = "There's an abandoned backpack with no trace of the owner in sight." +
			"\nInside is a grappling hook. Feeling only mild guilt, you take the grappling hook." +
			"\n\nThere's nothing else here. Better head West.";

		grapplingHook = true;
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			playerState = States.easternPath;
		}
	}

	void State_east_02(){
		if (snakeFlute == false) {
			SuperText.text = "You see a shiny red stone on a pedestal." +
			"\nUnfortunately, it's surrounded by snakes. They don't look friendly." +
			"\n\nBetter head back West. Unless you want to press Enter and try braving the snakes.";

			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				playerState = States.easternPath;
			}

			else if (Input.GetKeyDown (KeyCode.Return)) {
				playerState = States.death;
			}		
		} 

		else if (snakeFlute == true) {
			SuperText.text = "You see a shiny red stone on a pedestal." +
				"\nThough your musical ability is questionable, you play that fancy snake-shaped flute you found earlier." +
				"\nThe snakes are charmed, if only because you tried your best. They seem placid now and probably won't bite you." +
				"\n\nPress Enter to claim the stone and return to the temple entrance.";

			redStone = true;

			if (Input.GetKeyDown (KeyCode.Return)) {
				playerState = States.entrance;
			}		
		}
	}

	void State_south_01(){
		if (redStone == false || blueStone == false) {
			playerState = States.death;
		}

		else if (redStone == true && blueStone == true){
		SuperText.text = "Shimmering in the dark is a beautiful green stone." +
			"\nYou take it without hesitation." +
				"\n\nThat looks to be the last key. Press Up to return to the temple entrance.";

			greenStone = true;

			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				playerState = States.entrance;
			}			
		}
	}

	void State_west_01(){
		if (grapplingHook == false) {
			SuperText.text = "You see a luminous blue stone resting on a pedestal." +
			"\nAll that stands between you and the stone is a ravine. A really wide and deep ravine." +
			"\nThere are branches overhead, but how are you supposed to utilize those?" +
			"\n\nBetter back East. Unless you want to press Enter to try jumping over it.";

			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				playerState = States.westernPath;
			} 

			else if (Input.GetKeyDown (KeyCode.Return)) {
				playerState = States.death;
			}		
		} 

		else if (grapplingHook == true) {
			SuperText.text = "You see a luminous blue stone resting on a pedestal." +
				"\nAll that stands between you and the stone is a ravine." +
				"\nSummoning your courage, you latch onto the branches above with the grappling hook and swing across." +
				"\n\nPress Enter to claim the stone and return to the temple entrance.";

			blueStone = true;

			if (Input.GetKeyDown (KeyCode.Return)) {
				playerState = States.entrance;
			}		
		}
	}

	void State_west_02(){
		SuperText.text = "Sitting conspicuously on a stump is... a snake!" +
			"\nOh, wait. It's just a piece of wood carved to look like a snake." +
			"\nOn closer inspection, it appears to be flute." +
			"\nThinking it might be useful, you take it with you." +
			"\n\nThere's nothing else here. Better head back East.";

		snakeFlute = true;

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			playerState = States.westernPath;
		} 
	}

	void State_templeInterior(){
		SuperText.text = "Cautiously, you enter the now open temple." +
			"\nOn a great stone pedestal rests... a note?" +
			"\nIt reads:" +
			"\n\"If you want the Rainbow Stone, come and get it.\"" +
			"\n\nTo be continued..." +
			"\n\nPress R to restart.";

		redStone = false;
		blueStone = false;
		greenStone = false;
		grapplingHook = false;
		snakeFlute = false;

		if (Input.GetKeyDown (KeyCode.R)) {
			playerState = States.entrance;
		} 	
	}
}
