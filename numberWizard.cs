using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization

	void Start () {
	StartGame();
	}

void StartGame () {

		max = 1000;
		min = 1;
		guess = 500;
		print ("===============================================");
		print ("Welcome to number wizard");
		print ("Pick a number in your head but do not tell me ");
		
		print ("The highest number you can pick is: " + max);
		print ("The lowest number you can pick is: " + min);
		
		print ("is your number highet or lower tham " + guess );
		print ("up arrow for higher, down arrow for lower, return for equal");
		max = max +1;
}
	
void NextGuess ( ){
		guess = (max + min)/2;
		print ("higher or lower than "+ guess  );		
		print ("up arrow for higher, down arrow for lower, return for equal");
}		

								
	// Update is called once per frame
	void Update () {
	
	if (Input.GetKeyDown (KeyCode.UpArrow)) {
	
	//print ("Up arrow pressed");
	min = guess;
	NextGuess();
	} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
	//print ("Down arrow pressed");
	max = guess;
	NextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			
			print ("I Won");
			Start();
		}
		
				
	
	}
}
