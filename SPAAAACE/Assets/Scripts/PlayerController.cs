using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//Specify a variable for the 
	private Rigidbody2D rigid;
	private Transform transform;
	public float speed;
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public int health;
	public ParticleSystem particles;
	public GameObject[] hearts;
	public GameObject explosionEffect;


	// Use this for initialization
	void Start () {
		rigid = this.GetComponent<Rigidbody2D> ();
		transform = this.GetComponent<Transform> ();

		ShowHearts ();
	}

	private void ShowHearts(){
		//Turn off all hearts
		for (int i = 0; i < hearts.Length; i++) {
			hearts [i].SetActive (false);
		}

		//Turn hearts according to health
		for(int i = 0; i < health; i++){
			hearts [i].SetActive (true);
		}
	}

	public void OnCollisionEnter2D (Collision2D collider){
		print ("Ship Collision");
		health--;
		ShowHearts ();

		if (health <= 0){
			Destroy(this.gameObject);
			Instantiate (explosionEffect, transform.position, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Space))
		{
			GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
			//shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);
			//shot.AddForce(shotPos.forward * shotForce);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			rigid.velocity = new Vector2 (0, speed);
			transform.localEulerAngles = new Vector3 (0, 0, 0);
			particles.Emit (1);
		} 
			

		if (Input.GetKey (KeyCode.DownArrow)) {
			rigid.velocity = new Vector2 (0, -speed);
			transform.localEulerAngles = new Vector3 (0, 0, 180);
			particles.Emit (1);
				}

		if (Input.GetKey (KeyCode.RightArrow)) {
			rigid.velocity = new Vector2 (speed, 0);
			transform.localEulerAngles = new Vector3 (0, 0, -90);
			particles.Emit (1);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rigid.velocity = new Vector2 (-speed, 0);
			transform.localEulerAngles = new Vector3 (0, 0, 90);
			particles.Emit (1);
		}

		if (Input.GetKey (KeyCode.UpArrow) && Input.GetKey (KeyCode.RightArrow)) {
			rigid.velocity = new Vector2 (speed, speed);
			transform.localEulerAngles = new Vector3 (0, 0, -45);
			particles.Emit (1);
		}

		if (Input.GetKey (KeyCode.DownArrow) && Input.GetKey (KeyCode.RightArrow)) {
			rigid.velocity = new Vector2 (speed, -speed);
			transform.localEulerAngles = new Vector3 (0, 0, -135);
			particles.Emit (1);
		}

		if (Input.GetKey (KeyCode.DownArrow) && Input.GetKey (KeyCode.LeftArrow)) {
			rigid.velocity = new Vector2 (-speed, -speed);
			transform.localEulerAngles = new Vector3 (0, 0, 135);
			particles.Emit (1);
		}

		if (Input.GetKey (KeyCode.UpArrow) && Input.GetKey (KeyCode.LeftArrow)) {
			rigid.velocity = new Vector2 (-speed, speed);
			transform.localEulerAngles = new Vector3 (0, 0, 45);
			particles.Emit (1);
		}

		switch (health) {
		case 1: //do something; break;
		case 2:
		default:
			break;
		}
	}
}
