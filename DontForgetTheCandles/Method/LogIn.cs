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
                        /*
                        Fungerar ej att ha detta här.. för då får man inte med return user? 
                        Console.WriteLine("Press any key to proceed...");
                        Console.ReadKey();
                        Console.Clear();
                        MainMenu.MainMenuMethod();
                        */
                        return user;
                    }

                    /*
                    //FUNGERAR EJ ATT HA EN ELSE HÄR FÖR OM INTE ID'T ÄR 100 SOM LIGGER FÖRST I LISTAN SÅ KÖRS ÄNDÅ ELSE, HUR LÖSER MAN FELHANTERING FÖR FELINMATADE SIFFROR?
                    // SKRIVER MAN IN FEl SIFFROR NU SÅ SKICKAS MAN ÄNDÅ TILL MAINMENU EFTERSOM DEN METODEN LIGGER I STARTSCREEN CASE 1. 
                    else
                    {
                        Console.Clear();
                        ConsoleColor prevColor = Console.ForegroundColor; // Sparar nuvarande textfärg i variablen prevColor
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n* * * * * * * * * * * * * * * *");
                        Console.WriteLine("!ERROR!");
                        Console.WriteLine("Unvalid ID");
                        Console.WriteLine("Press a key and try again :)(:");
                        Console.WriteLine("* * * * * * * * * * * * * * * *");
                        Console.ForegroundColor = prevColor;
                        Console.ReadKey();
                        Console.Clear();
                        LogInMethod();
                        return null; 
                    }
                    */
                    
                }
                return null; 
            }
            catch (Exception) // Hit skickas man om man skriver in annat än siffror
            {
                Console.Clear();
                ConsoleColor prevColor = Console.ForegroundColor; // Sparar nuvarande textfärg i variablen prevColor
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n* * * * * * * * * * * * * * * *");
                Console.WriteLine("!ERROR!");
                Console.WriteLine("Login ID = Numbers only");
                Console.WriteLine("Press a key and try again :)(:");
                Console.WriteLine("* * * * * * * * * * * * * * * *");
                Console.ForegroundColor = prevColor;
                Console.ReadKey();
                Console.Clear();
                LogInMethod();
                return null; 
            }



        }
    }
}
