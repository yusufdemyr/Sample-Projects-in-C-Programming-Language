using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("---DICE GAME---");
            Console.Write("\n Please Enter Your Name:");
            string name = Console.ReadLine();
            string player1 = ("Deniz Akay");
            string player2 = ("Ateş Dağhan");
            int i = 0; //Toplam puan
            Console.WriteLine("\n Please Select From The Options Below: \n 1-Game Mode 1: Throw Dice Randomly \n 2-Game Mode 2: Throw Dice Yourself \n 3-Show High Score Table \n 4-Exit");
            double choose;
            choose = Convert.ToInt32(Console.ReadLine());
            
            if(choose == 1)
            { Random rnd = new Random();
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int dice3 = rnd.Next(1, 7);
                int dice4 = rnd.Next(1, 7);
                Console.WriteLine("Dice1= " + dice1 + "\nDice2= " + dice2 + "\nDice3= " + dice3 + "\nDice4= " + dice4);

            }
            if(choose == 2 )
            {
                int dice1, dice2, dice3, dice4;
                Console.WriteLine("Please Enter A Number Between 1 And 6 For Each Dice");
                Console.WriteLine("Please Enter Dice 1: ");
                dice1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Dice 2: ");
                dice2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Dice 3: ");
                dice3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Dice 4: ");
                dice4 = Convert.ToInt32(Console.ReadLine());

                if ((0<dice1<7) || (0<dice2<7) || (0<dice3<7) || (0<dice4<7)) ;
                { }
            }
            
            Console.ReadLine();
        }
    }
}
