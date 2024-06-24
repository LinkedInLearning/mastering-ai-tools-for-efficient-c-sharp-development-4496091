using System;

/// <summary>
/// Enum representing the possible choices in the game.
/// </summary>
enum Choice
{
    Rock,
    Paper,
    Scissors
}

/// <summary>
/// Represents a player in the game.
/// Provides a method to make a choice based on a string input.
/// </summary>
class Player
{
    /// <summary>
    /// Converts a string input into a Choice enum value.
    /// </summary>
    /// <param name="input">The user's choice as a string.</param>
    /// <returns>The corresponding Choice enum value.</returns>
    public Choice MakeChoice(string input)
    {
        // Convert the input string to a Choice enum, ignoring case sensitivity
        return (Choice)Enum.Parse(typeof(Choice), input, true);
    }
}

/// <summary>
/// Represents the computer player, inheriting from Player.
/// Makes random choices using the Random class.
/// </summary>
class ComputerPlayer : Player
{
    // Instance of Random to generate random choices
    private Random random = new Random();

    /// <summary>
    /// Generates a random choice for the computer player.
    /// </summary>
    /// <returns>A randomly selected Choice enum value.</returns>
    public Choice MakeRandomChoice()
    {
        // Array of possible choices
        Choice[] choices = { Choice.Rock, Choice.Paper, Choice.Scissors };

        // Return a randomly selected choice
        return choices[random.Next(choices.Length)];
    }
}

/// <summary>
/// Contains the logic to determine the winner of the game.
/// </summary>
class GameRule
{
    /// <summary>
    /// Determines the winner based on the choices of the user and the computer.
    /// </summary>
    /// <param name="userChoice">The user's choice.</param>
    /// <param name="computerChoice">The computer's choice.</param>
    /// <returns>A string indicating the result of the game.</returns>
    public string DetermineWinner(Choice userChoice, Choice computerChoice)
    {
        // Check for a tie
        if (userChoice == computerChoice)
        {
            return $"Both players selected {userChoice}. It's a tie!";
        }

        // Check for user win conditions
        if ((userChoice == Choice.Rock && computerChoice == Choice.Scissors) ||
            (userChoice == Choice.Scissors && computerChoice == Choice.Paper) ||
            (userChoice == Choice.Paper && computerChoice == Choice.Rock))
        {
            return $"You win! {userChoice} beats {computerChoice}.";
        }

        // Otherwise, the computer wins
        return $"You lose! {computerChoice} beats {userChoice}.";
    }
}

/// <summary>
/// Orchestrates the game flow, interacting with the user and managing game state.
/// </summary>
class Game
{
    // Instances of Player, ComputerPlayer, and GameRule
    private Player player = new Player();
    private ComputerPlayer computerPlayer = new ComputerPlayer();
    private GameRule gameRule = new GameRule();

    /// <summary>
    /// Starts the game loop, prompting the user for input and determining the game outcome.
    /// </summary>
    public void Start()
    {
        while (true)
        {
            // Prompt the user for input
            Console.WriteLine("Enter rock, paper, or scissors (or 'quit' to exit):");
            string input = Console.ReadLine().ToLower();

            // Check if the user wants to quit
            if (input == "quit")
            {
                Console.WriteLine("Game exited.");
                break;
            }

            // Validate the user's input and convert it to a Choice enum
            if (!Enum.TryParse(input, true, out Choice userChoice))
            {
                Console.WriteLine("Invalid choice, please try again.");
                continue;
            }

            // Get a random choice from the computer player
            Choice computerChoice = computerPlayer.MakeRandomChoice();

            // Determine the result of the game
            string result = gameRule.DetermineWinner(userChoice, computerChoice);
            Console.WriteLine(result);
        }
    }
}

/// <summary>
/// Entry point of the application.
/// </summary>
class Program
{
    /// <summary>
    /// Main method that starts the game.
    /// </summary>
    /// <param name="args">Command line arguments.</param>
    static void Main(string[] args)
    {
        // Create a new game instance and start the game
        Game game = new Game();
        game.Start();
    }
}
