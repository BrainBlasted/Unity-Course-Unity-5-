using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour {
	int max;
	int min;
	int guess;
	public int max_guesses;
	public int guesscount;
	public Text text;


	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Is the number higher, lower, or equal to " + guess + "?";
	}
	

	void StartGame () {
		max_guesses = 10;
		guesscount = 0;
		max = 1000;
		min = 1;
		guess = Random.Range(max, min);

		max = max + 1;
	}

	public void higher(){
		Debug.Log("The number was higher than " + guess + ".");
		min = guess;
		NextGuess();
	}

	public void NextGuess() {
		guess = ((max + min)/2);
		guesscount++;
		max_guesses = (max_guesses - 1);
		if (max_guesses <= 0){
			SceneManager.LoadScene("Lose");
		}
	}

	public void lower(){
		Debug.Log("The number was lower than " + guess + ".");
		max = guess;
		NextGuess();
	}

	public void equal(){
		Debug.Log("The number was equal to " + guess + ".");
		Debug.Log("Guesses left: " + max_guesses);
		Debug.Log(guesscount + " guesses made.");
	}
}
