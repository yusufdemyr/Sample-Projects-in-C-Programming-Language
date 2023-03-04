using System;

namespace asdsaddadsada
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("WELCOME TO DICE GAME");
			Console.Write("\n\nPlease Enter your Name:");
			// Previous players' usernames
			string player1 = "Messi", player2 = "Ronaldo", username = Console.ReadLine();
			int dice1 = 0, dice2 = 0, dice3 = 0, dice4 = 0, totalDice = 0;
			int p1score = 300, p2score = 450, sum = 0;

			if (string.IsNullOrWhiteSpace(username))
			{
				Console.WriteLine("Please enter your name: ");
				username = Console.ReadLine();
			}

			Console.WriteLine("\nPlease select an option from the Menu, " + username + "; \n\n1-)Game Mode 1: Throw Dice Randomly \n2-)Game Mode 2: Throw Dice Yourself \n3-)Show High Score Table \n4-)Exit");
			string choose;// Control variable
			choose = Console.ReadLine();

			if (!(choose == "1" || choose == "2" || choose == "3" || choose == "4"))
			{
				Console.WriteLine("Wrong choice, please select again: ");
				choose = Console.ReadLine();
			}


			if (choose == "3")
			{// Displays high score table
				Console.WriteLine(player1 + ":" + p1score);
				Console.WriteLine(player2 + ":" + p2score);
				Console.ReadLine();
			}
			if (choose == "4")
			{
				Console.WriteLine("You exited the game, see you again.");
				dice1 = 0; dice2 = 0; dice3 = 0; dice4 = 0; totalDice = 0;
			}

			if (choose == "1")
			{// Leads to game mode1
				Random rnd = new Random();
				dice1 = rnd.Next(1, 7);
				dice2 = rnd.Next(1, 7);
				dice3 = rnd.Next(1, 7);
				dice4 = rnd.Next(1, 7);
				Console.WriteLine("Dice1= " + dice1 + "\nDice2= " + dice2 + "\nDice3= " + dice3 + "\nDice4= " + dice4);
				totalDice = dice1 + dice2 + dice3 + dice4;
			}
			if (choose == "2")
			{
				Console.WriteLine("\nPlease enter a number for each dice");
				Console.WriteLine("\nPlease enter dice1: ");
				dice1 = Convert.ToInt16(Console.ReadLine());
				Console.WriteLine("Please enter dice2: ");
				dice2 = Convert.ToInt16(Console.ReadLine());
				Console.WriteLine("Please enter dice3: ");
				dice3 = Convert.ToInt16(Console.ReadLine());
				Console.WriteLine("Please enter dice4: ");
				dice4 = Convert.ToInt16(Console.ReadLine());
				Console.WriteLine("Dice1= " + dice1 + "\nDice2= " + dice2 + "\nDice3= " + dice3 + "\nDice4= " + dice4);
				totalDice = dice1 + dice2 + dice3 + dice4;
				if (!(1 <= dice1 && dice1 <= 6 && 1 <= dice2 && dice2 <= 6 && 1 <= dice3 && dice3 <= 6 && 1 <= dice4 && dice4 <= 6))
				{

					Console.WriteLine("You entered invalid input, enter to try again");
					// Gives you another chance to play gamemode2
					Console.WriteLine("\nPlease enter a number for each dice");
					Console.WriteLine("\nPlease enter dice1: ");
					dice1 = Convert.ToInt16(Console.ReadLine());
					Console.WriteLine("Please enter dice2: ");
					dice2 = Convert.ToInt16(Console.ReadLine());
					Console.WriteLine("Please enter dice3: ");
					dice3 = Convert.ToInt16(Console.ReadLine());
					Console.WriteLine("Please enter dice4: ");
					dice4 = Convert.ToInt16(Console.ReadLine());

					totalDice = dice1 + dice2 + dice3 + dice4;

					if (!(1 <= dice1 && dice1 <= 6 && 1 <= dice2 && dice2 <= 6 && 1 <= dice3 && dice3 <= 6 && 1 <= dice4 && dice4 <= 6))
					{
						// If any dices are not in range of [1,6]
						Console.WriteLine("\nYou entered invalid input, exiting the game...");

					}
				}

			}

			if ((1 <= dice1 && dice1 <= 6 && 1 <= dice2 && dice2 <= 6 && 1 <= dice3 && dice3 <= 6 && 1 <= dice4 && dice4 <= 6))
			{
				// If all dices are between 1 and 6
				if (dice1 == dice2 && dice2 == dice3 && dice3 == dice4)
				{// If all dices are equal to each others
					sum = sum + 300;
					Console.WriteLine("You earned 300 points from Rule 1");

					if (12 <= totalDice && totalDice <= 16)
					{// If sum of dices are higher than 12 and lower than 16 add +2
						sum = sum + 2;
						Console.WriteLine("You earned 2 points from Rule 7");
					}
					if (8 <= totalDice && totalDice <= 11 || 17 <= totalDice && totalDice <= 20)
					{// If sum of dices are higher than 8 and lower than 11 or higher than 17 and lower than 20 add +4
						sum = sum + 4;
						Console.WriteLine("You earned 4 points from Rule 8");
					}
					if (4 <= totalDice && totalDice <= 7 || 21 <= totalDice && totalDice <= 24)
					{// If sum of dices are higher than 4 and lower than 7 or higher than 21 and lower than 24 add +30
						sum = sum + 30;
						Console.WriteLine("You earned 30 points from Rule 9");
					}
					Console.WriteLine("\nYour total score is " + sum);
				}
				else
				{// If dices are not equal to each others                      
					if (12 <= totalDice && totalDice <= 16)
					{// If sum of dices are higher than 12 and lower than 16 add +2
						sum = sum + 2;
						Console.WriteLine("You earned 2 points from Rule 7");
					}
					if (8 <= totalDice && totalDice <= 11 || 17 <= totalDice && totalDice <= 20)
					{// If sum of dices are higher than 8 and lower than 11 or higher than 17 and lower than 20 add +4
						sum = sum + 4;
						Console.WriteLine("You earned 4 points from Rule 8");
					}
					if (4 <= totalDice && totalDice <= 7 || 21 <= totalDice && totalDice <= 24)
					{// If sum of dices are higher than 4 and lower than 7 or higher than 21 and lower than 24 add +30
						sum = sum + 30;
						Console.WriteLine("You earned 30 points from Rule 9");
					}
					Console.WriteLine("\nYour total score is " + sum);
				}
				Console.ReadKey();
			}
		}
	}
}
