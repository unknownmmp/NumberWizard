using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    int win = 0;

    // Use this for initialization
    void Start()
    {
        print("Welcome to Number Wizard");
        print("Pick a number. If u tell me the number, u lose.");
        print("If I find the number, u lose.");
        print("If u lose, u die :)");
        AskAgain(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (win == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                AskAgain(1);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                print("Cya");
                Debug.Break();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                print("Hm... Lower... Ok...");
                max = guess - 1;
                CheckGuess();
                AskAgain(0);
            }

            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                print("Higher? Ok.");
                min = guess + 1;
                CheckGuess();
                AskAgain(0);
            }

            else if (Input.GetKeyDown(KeyCode.Return))
            {
                ComputerWins();
            }
        }
    }

    void AskAgain(int restart)
    {
        //print("Debug: askagain");
        //print("Debug: min:" + min + " max:" + max + " guess:" + guess);
        if (restart == 1)
        {
            max = 1000;
            min = 1;
            guess = 500;
            print("The highest number u can pick is " + max);
            print("The lowest is " + min);
            print("U pick any higher than " + max + " or any lower than " + min + ", u lose. And die :)");
            win = 0;
        }
        if (guess == min) print("So... Equal or higher than " + guess + "?");
        else if (guess == max) print("So... Equal or lower than " + guess + "?");
        else print("So.... Is the number higher or lower than " + guess + "?");
        print("(Up Arrow-higher, Down Arrow-lower, Return-equals)");
    }

    void CheckGuess()
    {
        guess = (max + min) / 2;
        if (guess < 1) guess = 1;
        else if (guess > 1000) guess = 1000;
    }

    void ComputerWins()
    {
        print("Well... I can think in at least 69 ways to kill u right now...");
        print("But... I'll give you another chance to beat me. :) ");
        print("Wanna try again? U will never beat me though. Dont even try :) ");
        print("(Space-restart, E-end(die))");
        win = 1;
    }
}
