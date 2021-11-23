using System;
using System.Collections.Generic;
using DontForgetTheCandles.Class;

namespace DontForgetTheCandles.Method
{
    public class LogIn
    {

        public static User LogInMethod()
        {
            Console.Clear();
            Console.Write("\nEnter user ID: ");
            try
            {
            int userInput = Convert.ToInt32(Console.ReadLine().Trim()); // .Trim() kan läsa inputen ändå om användaren räkar skriva mellanslag innan. 

                foreach (var user in User.users)
                {
                    if (userInput == user.ID)
                    {
                        Console.WriteLine("Welcome {0} :)", user.Name);
                        Console.WriteLine("Press any key to proceed...");
                        Console.ReadKey();
                        Console.Clear();
                        return user;
                    }
                }
                // Om man skriver in fel siffror
                Console.Clear();
                ConsoleColor prevColor = Console.ForegroundColor; // Sparar nuvarande textfärg i variablen prevColor
                Console.ForegroundColor = ConsoleColor.DarkRed; // Byter färg på texten
                Console.WriteLine("\n* * * * * * * * * * * * * * * *");
                Console.WriteLine("!ERROR!");
                Console.WriteLine("Unvalid ID");
                Console.WriteLine("Press a key and try again :)(:");
                Console.WriteLine("* * * * * * * * * * * * * * * *");
                Console.ForegroundColor = prevColor; // Ändrar tillbaka till föregående färg
                Console.ReadKey();
                Console.Clear();
                StartScreen.StartMenu(); 
                return null; 
            }
            catch (Exception) // Hit skickas man om man skriver in annat än siffror
            {
                Console.Clear();
                ConsoleColor prevColor = Console.ForegroundColor; // Sparar nuvarande textfärg i variablen prevColor
                Console.ForegroundColor = ConsoleColor.DarkRed; // Byter färg på texten
                Console.WriteLine("\n* * * * * * * * * * * * * * * *");
                Console.WriteLine("!ERROR!"); 
                Console.WriteLine("Login ID = Numbers only");
                Console.WriteLine("Press a key and try again :)(:");
                Console.WriteLine("* * * * * * * * * * * * * * * *");
                Console.ForegroundColor = prevColor; // Ändrar tillbaka till föregående färg
                Console.ReadKey();
                Console.Clear();
                StartScreen.StartMenu();
                return null; 
            }



        }
    }
}
