using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

	public enum PowerupType {healthPickup, shield, gottaGoFast};
	public PowerupType myType;
	public Sprite[] images;

	// Use this for initialization
	void Start () {
		switch (myType) {
		case PowerupType.healthPickup:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [0];
			break;
		case PowerupType.shield:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [1];
			break;
		case PowerupType.gottaGoFast:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [2];
			break;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("We hit a powerup!");

		switch (myType) {
		case PowerupType.gottaGoFast:
			other.GetComponent<PlayerController> ().speed *= 1.8f;
			break;
		case PowerupType.healthPickup:

			break;
		case PowerupType.shield:

			break;
		default:
			
			break;
		}

		Destroy (this.gameObject);

	}
}
