using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    private int maxNumber;

    private int minNumber;

    private int currentChoice;

	// Use this for initialization
	void Start () {
        initializeGame();
        displayInstruction();
	}

    private void initializeGame() {
        maxNumber = 1001;
        minNumber = 1;
        currentChoice = 500;
    }

    private void displayInstruction() {
        print("************************");
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me!");
        print("The highest number you can pick is " +  (maxNumber - 1));
        print("The lowest number you can pick is " +  minNumber);
        print("Is you number higher or lower than " + currentChoice + "?");
        print("Up = higher, down = lower, return = equal");
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
            minNumber = currentChoice;
            nextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            maxNumber = currentChoice;
            nextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            print("I won, Let's start again");
            initializeGame();
            displayInstruction();
        }
	}

    void nextGuess() {
        currentChoice = (maxNumber + minNumber) / 2;
        print("Higher or lower than " + currentChoice);
        print("Up = higher, down = lower, return = equal");
    }
}
