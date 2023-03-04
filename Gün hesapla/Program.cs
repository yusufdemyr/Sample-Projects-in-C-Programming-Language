using System;

namespace Gün_hesapla
{
    class Program
    {
        static void Main(string[] args)
        {
            char userChoice;

            Console.WriteLine("Please choose one of the following options");
            Console.WriteLine("1 - Gün Çıkar");
            Console.WriteLine("2 - Gün Ekle");
            userChoice = char.ToLower(Console.ReadKey(true).KeyChar);
            Console.WriteLine("You choice " + userChoice);

            if (userChoice == 1)

                   
            {
               
                Console.WriteLine("Çıkarmak istediğiniz gün sayısı : ");
                int userInput;
                userInput = Convert.ToInt32((Console.ReadLine()));
                Console.WriteLine("Today = {0}", DateTime.Today);           //Bugünün tarihini yazdırır.
                Console.WriteLine("Çıkardığımız Gün = {0}", DateTime.Today.AddDays(-userInput));    //Kullanıcının istediği gün sayısını çıkarır.

                DateTime today = DateTime.Now;
                DateTime answer = today.AddDays(-userInput);
                Console.WriteLine("Today: {0:dddd}", today);
                Console.WriteLine(userInput + " days from today: {0:dddd}", answer);
            }
            
            else if (userChoice == 2) 
            {
                Console.WriteLine("Eklemek istediğiniz gün sayısı : ");

            }

        }
    }
}
