namespace Rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] choices = { "rock", "paper", "scissors" };

            Console.WriteLine("ROCK PAPER SCISSORS Mini-Game!");

            string userSelection = FindUserSelection(choices);

            Random random = new Random();
            int npcChoiceIndex = random.Next(choices.Length);
            string npcChoice = choices[npcChoiceIndex];

            Console.WriteLine($"NPC chose: {npcChoice}");

            string result = WinnerSelection(userSelection, npcChoice);
            Console.WriteLine(result);
        }

        static string FindUserSelection(string[] choices)
        {
            while (true)
            {
                Console.WriteLine("Enter your choice (rock, paper, or scissors): ");
                string userSelection = Console.ReadLine().ToLower();

                if (choices.Contains(userSelection))
                {
                    return userSelection;
                }

                Console.WriteLine($"There is no such selection as \"{userSelection}\". Please enter rock, paper, or scissors.");
            }
        }

        static string WinnerSelection(string userSelection, string npcChoice)
        {
            if (userSelection == npcChoice)
            {
                return "It's a tie";
            }
            else if ((userSelection == "rock" && npcChoice == "scissors") ||
                    (userSelection == "paper" && npcChoice == "rock") ||
                    (userSelection == "scissors" && npcChoice == "paper"))
            {
                return "You WON";
            }
            else
            {
                return "You lost. Try again";
            }
        }
    }
}
