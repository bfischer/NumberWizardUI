using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;
	int maxGuesses = 10;

	public Text GuessText;

	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		NextGuess();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void GuessHigher() {
		min = guess;
		NextGuess();
	}

	public void GuessLower() {
		max = guess;
		NextGuess();
	}
	
	void NextGuess () {
		guess = Random.Range(min, max+1);
		maxGuesses -= 1;

		GuessText.text = guess.ToString();

		if(maxGuesses <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
