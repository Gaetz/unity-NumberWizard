using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start()
    {
        ResetGame();
        // Game start
        Guess();
        Instructions();
    }

    void ResetGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        // Display
        Intro();
        // Allow to reach max number
        max = max + 1;
    }

    void Intro()
    {
        print("==============================");
        print("-= Welcome to Number Wizard =-");
        print("==============================");

        print("Pick a number in your head but don't tell me.");
        print("The number you choose must be between " + min + " and " + max + ".");
    }

    void Instructions()
    {
        print("Up arrow for HIGHER, down arrow for LOWER, return for EQUAL.");
    }

    void Guess()
    {
        print("Is the number HIGHER or LOWER than " + guess + " ?");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Guess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Guess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I guessed your number :)");
            print("");
            ResetGame();
        }
    }
}