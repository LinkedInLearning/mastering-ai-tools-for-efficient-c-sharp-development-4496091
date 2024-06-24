//--------------------------------------------------------------------------------------
// Program.cs
//
// This file contains the implementation of a simple Rock, Paper, Scissors game played
// between a human player and the computer. It demonstrates basic concepts of OOP such
// as inheritance, encapsulation, and polymorphism through the use of classes and enums.
// The game continues in a loop until the user decides to quit by entering 'quit'.
//
// Classes:
// - Choice: Enum representing the possible choices in the game.
// - Player: Represents a player in the game, capable of making a choice.
// - ComputerPlayer: Inherits from Player, makes random choices.
// - GameRule: Contains the logic to determine the winner of the game.
// - Game: Orchestrates the game flow, interacting with the user and managing game state.
// - Program: Contains the entry point of the application, where the game is started.
//
// Author: Jesse Freeman
//--------------------------------------------------------------------------------------
using System;

// Enum for the choices
enum Choice
{
    Rock,
    Paper,
    Scissors
}

/// <summary>
/// Represents a player in the game. Provides a method to make a choice based on a string input.
/// </summary>
/// <remarks>
/// The <c>MakeChoice</c> method converts a string input into a <c>Choice</c> enum value, ignoring case sensitivity.
/// </remarks>
class Player
{
    public Choice MakeChoice(string input)
    {
        return (Choice)Enum.Parse(typeof(Choice), input, true);
    }
}

class ComputerPlayer : Player
{
    private Random random = new Random();

    public Choice MakeRandomChoice()
    {
        // Array of possible choices
        Choice[] choices = { Choice.Rock, Choice.Paper, Choice.Scissors };
        
        // Randomly select a choice
        return choices[random.Next(choices.Length)];
    }
}

class GameRule
{
    public string DetermineWinner(Choice userChoice, Choice computerChoice)
    {
        if (userChoice == computerChoice)
        {
            return $"Both players selected {userChoice}. It's a tie!";
        }
        else if (userChoice == Choice.Rock && computerChoice == Choice.Scissors ||
                 userChoice == Choice.Scissors && computerChoice == Choice.Paper ||
                 userChoice == Choice.Paper && computerChoice == Choice.Rock)
        {
            return $"You win! {userChoice} beats {computerChoice}.";
        }
        else
        {
            return $"You lose! {computerChoice} beats {userChoice}.";
        }
    }
}

class Game
{
    private Player player = new Player();
    private ComputerPlayer computerPlayer = new ComputerPlayer();
    private GameRule gameRule = new GameRule();

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("Enter rock, paper, or scissors (or 'quit' to exit):");
            string input = Console.ReadLine().ToLower();
    
            if (input == "quit")
            {
                Console.WriteLine("Game exited.");
                break;
            }
    
            if (!Enum.TryParse(input, true, out Choice userChoice))
            {
                Console.WriteLine("Invalid choice, please try again.");
                continue;
            }
            
            Choice computerChoice = computerPlayer.MakeRandomChoice();
    
            string result = gameRule.DetermineWinner(userChoice, computerChoice);
            Console.WriteLine(result);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.Start();
    }
}