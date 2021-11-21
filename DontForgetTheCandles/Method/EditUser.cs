using System;
using DontForgetTheCandles.Class;

namespace DontForgetTheCandles.Method
{
    public class EditUser
    {

        public static void EditUserMethod()
        {
            Console.Clear(); 
            int userInput = 0;

            Console.WriteLine();
            Console.WriteLine(@"Choose what you want to edit: 
            1) Edit name
            2) Edit age
            3) Edit city");

            try
            {
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception) // Om userInput inte är en siffra så skickas man hit. 
            {
                Console.Clear();
                ConsoleColor prevColor = Console.ForegroundColor; // Sparar nuvarande textfärg i variablen prevColor
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n* * * * * * * * * * * * * * * *");
                Console.WriteLine("!ERROR!");
                Console.WriteLine("Wrong input");
                Console.WriteLine("Press a key and try again :)(:");
                Console.WriteLine("* * * * * * * * * * * * * * * *");
                Console.ForegroundColor = prevColor;
                Console.ReadKey();
                Console.Clear();
                EditUserMethod();
            }


            switch (userInput)
            {
                case 1:
                    Console.Write("Enter new name: ");
                    CurrentUser.current.Name = Console.ReadLine();
                    Console.WriteLine("Press any key to return to Main Menu...");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu.MainMenuMethod();
                    break;
                case 2:
                    Console.Write("Enter new age: ");
                    CurrentUser.current.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Press any key to return to Main Menu...");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu.MainMenuMethod();
                    break;
                case 3:
                    Console.Write("Enter new city: ");
                    CurrentUser.current.City = Console.ReadLine();
                    Console.WriteLine("Press any key to return to Main Menu...");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu.MainMenuMethod();
                    break;
                default:
                    Console.Clear();
                    ConsoleColor prevColor = Console.ForegroundColor; // Sparar nuvarande textfärg i variablen prevColor
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n* * * * * * * * * * * * * * * *");
                    Console.WriteLine("!ERROR!");
                    Console.WriteLine("{0} is not a valid NR", userInput);
                    Console.WriteLine("Press a key and try again :)(:");
                    Console.WriteLine("* * * * * * * * * * * * * * * *");
                    Console.ForegroundColor = prevColor;
                    Console.ReadKey();
                    Console.Clear();
                    EditUserMethod(); 
                    break;
            }






        }


    }
}
