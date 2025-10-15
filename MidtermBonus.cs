namespace MidtermBonus;

class Program
{
    class HumanPlayer
    {
        private int points;

        // Constructor
        public HumanPlayer(int initial)
        {
            points = initial;
        }

        // Return current points
        public int GetPoints()
        {
            return points;
        }

        // Increase points by 5
        public void WinRound()
        {
            points += 5;
        }

        // Decrease points by 5
        public void LoseRound()
        {
            points -= 5;
        }

        // Human selects Rock, Paper, or Scissors
        public string HumanDecision()
        {
            string choice;
            while (true)
            {
                Console.Write("Enter your choice (Rock, Paper, or Scissors): ");
                choice = Console.ReadLine().Trim().ToLower();

                if (choice == "rock" || choice == "paper" || choice == "scissors")
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter Rock, Paper, or Scissors.");
                }
            }
        }
    }

    class ComputerPlayer
    {
        private static Random random = new Random();

        // Computer randomly chooses Rock, Paper, or Scissors
        public string ComputerDecision()
        {
            string[] options = { "rock", "paper", "scissors" };
            int index = random.Next(options.Length);
            return options[index];
        }
    }

    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Rock–Paper–Scissors Game ===");
            Console.Write("Enter initial points for human player: ");
            int initialPoints;

            // Validate input for points
            while (!int.TryParse(Console.ReadLine(), out initialPoints) || initialPoints <= 0)
            {
                Console.Write("Invalid input. Please enter a positive integer: ");
            }

            HumanPlayer human = new HumanPlayer(initialPoints);
            ComputerPlayer computer = new ComputerPlayer();

            while (human.GetPoints() > 0)
            {
                Console.WriteLine($"\nCurrent Points: {human.GetPoints()}");

                string humanChoice = human.HumanDecision();
                string computerChoice = computer.ComputerDecision();

                Console.WriteLine($"Computer chose: {computerChoice}");

                // Determine winner
                if (humanChoice == computerChoice)
                {
                    Console.WriteLine("It's a tie! No points gained or lost.");
                }
                else if ((humanChoice == "rock" && computerChoice == "scissors") ||
                         (humanChoice == "scissors" && computerChoice == "paper") ||
                         (humanChoice == "paper" && computerChoice == "rock"))
                {
                    Console.WriteLine("You win this round!");
                    human.WinRound();
                }
                else
                {
                    Console.WriteLine("You lose this round!");
                    human.LoseRound();
                }

                // Check if points are zero
                if (human.GetPoints() <= 0)
                {
                    Console.WriteLine("\nGame Over! Your points have reached zero.");
                    break;
                }

                // Ask if player wants another round
                Console.Write("\nDo you want to play another round? (yes/no): ");
                string answer = Console.ReadLine().Trim().ToLower();
                if (answer != "yes" && answer != "y")
                {
                    Console.WriteLine("Thanks for playing! Final Points: " + human.GetPoints());
                    break;
                }
            }
        }
    }
}
