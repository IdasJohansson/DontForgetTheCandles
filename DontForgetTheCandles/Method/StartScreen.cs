using System;
using DontForgetTheCandles.Class;

namespace DontForgetTheCandles.Method
{
    public class StartScreen
    {

        public static void InitialUsers()
        {
            User user = new User(id: 100, name: "Anna", age: 10, city: "Stockholm", nrOfLights: 1, boughtCandle: 5); // La in paramenternamnen bara som en reminder
            User user2 = new User(200, "Kalle", 15, "Stockholm", 2, 0);
            User user3 = new User(300, "Olle", 40, "Stockholm", 3, 5);
            User user4 = new User(400, "Lisa", 45, "Stockholm", 4, 10);
        }

        public static void InitialCandels()
        {
            Candle candle = new Candle(candleLighted: DateTime.Now, byUser: "Anna", room: "Livingroom", burnHours: 2, lightOut: DateTime.Now.AddHours(2));
            Candle candle2 = new Candle(candleLighted: DateTime.Now, byUser: "Kalle", room: "Kitchen", burnHours: 3, lightOut: DateTime.Now.AddHours(3));
            Candle candle3 = new Candle(candleLighted: DateTime.Now, byUser: "Olle", room: "Kitchen", burnHours: 4, lightOut: DateTime.Now.AddHours(4));
            Candle candle4 = new Candle(candleLighted: DateTime.Now, byUser: "Lisa", room: "Bedroom", burnHours: 4, lightOut: DateTime.Now.AddHours(4));
        }




        public static void StartMenu()
        {

            int userInput = 0; 

            Console.WriteLine("\nDON'T FORGET YOUR LIGHTED CANDLES...");
            Console.WriteLine(@"Enter one of below numbers:

            1) LOGIN
            2) CREATE NEW USER
            3) EXIT PROGRAM");

            
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
                StartMenu();
            }

            switch (userInput)
            {
                case 1:
                    // Metod för login 
                    CurrentUser.current = LogIn.LogInMethod();
                    // Även om man skriver in felanvändarid med siffror så kommer man vidare till mainmenu just nu eftersom metoden ligger här: 
                    MainMenu.MainMenuMethod();
                    break;
                case 2:
                    // Metod för create new user
                    AddUser.AddUserByInput(); 
                    break;
                case 3:
                    // Metod för exit program
                    ExitProgram.EndMessage(); 
                    break;
                default: // Om userinput är fel siffra
                    Console.Clear();
                    ConsoleColor prevColor = Console.ForegroundColor; // Sparar nuvarande textfärg i variablen prevColor
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n* * * * * * * * * * * * * * * *");
                    Console.WriteLine("!ERROR!");
                    Console.WriteLine("Valid numbers are: [1] [2] [3]");
                    Console.WriteLine("Press a key and try again :)(:");
                    Console.WriteLine("* * * * * * * * * * * * * * * *");
                    Console.ForegroundColor = prevColor;
                    Console.ReadKey();
                    Console.Clear();
                    StartMenu();
                    break;
            }


        }

    }
}
