using System;

class Program
{
    static void Main()
    {
        string[] options = { "rock", "paper", "scissors" };
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            Console.WriteLine("Enter your choice (rock, paper, or scissors): ");
            string playerChoice = Console.ReadLine().ToLower();

            if (Array.Exists(options, element => element == playerChoice))
            {
                int computerIndex = random.Next(options.Length);
                string computerChoice = options[computerIndex];

                Console.WriteLine($"Computer chose: {computerChoice}");

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (
                    (playerChoice == "rock" && computerChoice == "scissors") ||
                    (playerChoice == "scissors" && computerChoice == "paper") ||
                    (playerChoice == "paper" && computerChoice == "rock"))
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("You lose!");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose rock, paper, or scissors.");
            }

            Console.WriteLine("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";
        }
    }
}
