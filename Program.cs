using System;

enum Choice
{
    Rock,
    Paper,
    Scissors
}

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
        Choice[] choices = { Choice.Rock, Choice.Paper, Choice.Scissors };
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