using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour {

	public int Health = 3;
	public Sprite cracked;
	public Sprite cracked2;
	public Sprite[] picture;
	private int count = 0;
	private LevelManager levelManager;

	void Start(){
		levelManager = FindObjectOfType<LevelManager> ();
	}

	public void OnCollisionEnter2D (Collision2D collider){
		Health --;
		count++;
		print ("Collision");



//		if (Health == 2) {
//			GetComponent<SpriteRenderer> ().sprite = cracked;
//		} 
//
//		else if (Health == 1) {
//			GetComponent<SpriteRenderer> ().sprite = cracked2;
//		}

		if(Health <= 0){
			LevelManager.brickCount--;
			levelManager.CheckBrickCount ();
			Destroy(this.gameObject);
		}

		//Change the picture
		GetComponent<SpriteRenderer>().sprite = picture[count];
	}


}
