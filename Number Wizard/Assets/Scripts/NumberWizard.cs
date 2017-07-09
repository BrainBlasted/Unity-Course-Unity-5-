using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	
	// Maximum and Minimum variables
	int max;
	int min;
	int guess;
	
	void Start () {
		StartGame();
	}
	
	void StartGame() {
		max = 1000;
		min = 1;
		guess = 500;
	
		max = max + 1;
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me.");
		
		// Tell users the range they can pick numbers in
		print ("The highest number you can pick is "   + (max - 1)+ ".");
		print ("The lowest number you can pick is " + min +".");
		
		// Start asking player for Range.
		print ("Is the number higher or lower than " + guess + "?");
		print ("UpArrow = higher, DownArrow = lower, Enter = equal.");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print ("UpArrow pressed");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			// print ("DownArrow pressed");
			max = guess;
			NextGuess();
			
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!");
			StartGame();
		}
	}
	
	//Calulates the next guess
	void NextGuess() {
		guess = ( max + min ) / 2;
		print ("Is the number higher or lower than " + guess);
		print ("UpArrow = higher, DownArrow = lower, Enter = equal.");
	}
}
