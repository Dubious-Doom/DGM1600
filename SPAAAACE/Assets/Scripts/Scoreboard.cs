using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour {

	public int score;
	public Text display;
	public Text highscoreDisplay;
	public Text prevScoreDisplay;

	// Use this for initialization
	void Start () {
		score = 0;
			

	}

	public void IncrementScoreboard (int value){
		score += value;
		display.text = score.ToString ();
	}

	public void SaveScore(){
		int oldScore = GetScore ();
		PlayerPrefs.SetInt ("PrevScore", oldScore);

		if (score > oldScore)
			PlayerPrefs.SetInt ("PrevScore", oldScore);
	}

	public int GetScore(){
		return PlayerPrefs.GetInt ("HighScore");
	}

	public void OnDisable(){
		SaveScore ();
	}
	
	// Update is called once per frame
	void Update () {
		display.text = score.ToString ();
	}
}
