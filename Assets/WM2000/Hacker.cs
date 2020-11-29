using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    public int level;

    public enum Screen { HomeMenu, Password, Win };
    public Screen currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.Password)
        {
            GameWindow(input);
        }
        else
        {
            GameWindow(input);
        }

    }

    void GameWindow(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please choose valid level");
        }
    }

    void Game(string input)
    {
        if (input == "book")
        {
            Terminal.WriteLine("you win");
        }
        else
        {
            Terminal.WriteLine("Try again");
        }
    }


    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level" + level);
        Terminal.WriteLine("Please Enter youur password:");
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        currentScreen = Screen.HomeMenu;
        Terminal.WriteLine("What would you like to hack into?\n");

        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 1 for the NASA\n");

        Terminal.WriteLine("Enter your selection:");

    }

    void CookCurry(string meat)
    {
        Terminal.WriteLine("I am adding the " + meat);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
