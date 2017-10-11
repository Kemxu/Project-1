using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2 : MonoBehaviour {

    int num1 = 0;
    int max = 100;
    int min = 0;
    int answer = 50;

    void NextGuess()
    {
        print("Enter a number between - " + min + " and " + max);
    }

    void StartGame()
    {
        print("Up adds 1. Down subtracts 1. Right adds 10. Left subtracts 10.");
        print("---------------");
        NextGuess();
    }

    void Start () {
        StartGame();
	}
	
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("+1");
            NextGuess();
        }
        else

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("-1");
            NextGuess();
        }
        else
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("+10");
            NextGuess();
        }
        else

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("-10");
            NextGuess();
        }
    }
}
