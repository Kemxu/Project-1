using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 0;

    void NextGuess()
    {
        print("Please enter a number from " + min + " and " + max);
        print("Up for Bigger, Down for smaller, = for equal.");
    }

    void StartGame()
    {
        print("---------------");
        Debug.Log("Please enter a number from " + min + "and " + max + guess);
        print("Think of a number.");
        NextGuess();
    }

    void Start () {
        StartGame();
	}

    void Update() {

        
    }  
}
