using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	// load level
	public void LoadLevel(string name){
		Debug.Log("Level load requested for: " + name);
		SceneManager.LoadScene(name);
	}

	public void QuitRequest(){
		Debug.Log("Quit request received.");
		Application.Quit();
	}
}
