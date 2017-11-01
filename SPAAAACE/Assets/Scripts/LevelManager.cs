using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	void Start(){
		
	}
		
		
	public void LevelLoad(string lvl){
		SceneManager.LoadScene (lvl);
	}

	public void ExitGame (){ //Not have this function with a mobile app
		print ("Tried to exit.");
		Application.Quit ();
	}

	public void LoadNextLevel(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
		
	}

