using System;

namespace RockPaperScissors
{
    class Program
    {
        private const int Rock = 0;
        private const int Paper = 1;
        private const int Scissors = 2;
        private static int _flag = 1;
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();

            string playerChoice;
            int playerValue = -1;

            do
            {
            int computerValue = randomNumbers.Next(3);
            string computerChoice;

            // The code for your solution goes below this comment.
            if (computerValue == Rock)
            {
                computerChoice = "rock";

            }
            else if (computerValue == Paper)
            {
                computerChoice = "paper";

            }
            else 
            {
                computerChoice = "scissors";
            }



            Console.Clear();
            do
            {
                Console.Write("Please enter rock, paper or scissors ");
                playerChoice = Console.ReadLine().ToLower();
                switch (playerChoice)
                {
                    case "rock": { playerValue = Rock; _flag = 0; break; }
                    case "paper": { playerValue = Paper; _flag = 0; break; }
                    case "scissors": { playerValue = Scissors; _flag = 0; break; }
                    case "": { Console.WriteLine("Enter a valid choice."); break; }
                    default: { Console.WriteLine($"{playerChoice} is not valid choice"); break; }
                }
            }
            while (_flag != 0);

            Console.WriteLine($"Computer chose {computerChoice}, player chose {playerChoice}");
            if (playerValue == computerValue)
            {
                Console.WriteLine("It is a draw.");
            }
            else if ((playerValue - 1 == computerValue)
                || (playerValue == Rock && computerValue == Scissors))
            {
                Console.WriteLine("player Wins.");

            }
            else
            {
                Console.WriteLine("The Computer wins!");
            }
            } while (GetYesOrNo("Would you like to play again"));
        } 
        public static bool GetYesOrNo(string question)
        {

            char answer;
            while (true)  // infinite loop.  return will exit the method, thus terminating the loop
            {
                
                Console.Write($"{question} ");
                answer = Console.ReadKey().KeyChar;
                answer = char.ToLower(answer);
                if (answer.Equals('y'))
                    return true;
                if (answer.Equals('n'))
                    return false;
            }
        }
    }
}




