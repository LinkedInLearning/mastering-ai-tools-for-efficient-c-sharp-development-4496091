using System;

class Program
{
    static void Main(string[] args)
    {
        string[] choices = { "rock", "paper", "scissors" };
        Random random = new Random();
        string computerChoice = choices[random.Next(choices.Length)];

        string userChoice = "";
        bool isValidChoice = false;

        while (!isValidChoice)
        {
            Console.WriteLine("Enter rock, paper, or scissors (or 'quit' to exit):");
            userChoice = Console.ReadLine().ToLower();

            if (userChoice == "quit")
            {
                Console.WriteLine("Game exited.");
                return; // Exit the program
            }

            foreach (var choice in choices)
            {
                if (userChoice == choice)
                {
                    isValidChoice = true;
                    break;
                }
            }

            if (!isValidChoice)
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }

        // The rest of the game logic goes here
        if (userChoice == computerChoice)
        {
            Console.WriteLine($"Both players selected {userChoice}. It's a tie!");
        }
        else if (userChoice == "rock" && computerChoice == "scissors" ||
                 userChoice == "scissors" && computerChoice == "paper" ||
                 userChoice == "paper" && computerChoice == "rock")
        {
            Console.WriteLine($"You win! {userChoice} beats {computerChoice}.");
        }
        else
        {
            Console.WriteLine($"You lose! {computerChoice} beats {userChoice}.");
        }
    }
}