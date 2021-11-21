using System;
using DontForgetTheCandles.Class;
using DontForgetTheCandles.Method; 

namespace DontForgetTheCandles.Method
{
    public class MainMenu
    {

        public static void MainMenuMethod()
        {
            int userInput = 0;
            
            Console.WriteLine("\n * MAIN MENU *");
            Console.WriteLine(@"Enter one of below numbers:

            1) REGISTER A NEW LIGHTED CANDLE 
            2) VIEW LIST OF CANDLES
            3) REGISTER PURCHASE OF CANDLE (Counter)
            4) SHOW LOGGED IN USER DETAILS
            5) EDIT LOGGED UN USER DETAILS
            6) SHOW LIST OF ALL USERS
            7) EXIT PROGRAM");


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
                MainMenuMethod(); // Gör så att man får börja om i menyvalet.
            }

            switch (userInput)
            {
                case 1:
                    // Metod för skapa ett nytt tänt ljus som också adderas till listan av ljus
                    AddLightedCandle.AddLightedCandleMethod(); 
                    break;
                case 2:
                    // Metod för visa lista med ljus
                    Candle.PrintListWithCandles(); 
                    break;
                case 3:
                    // Metod för counter som adderar inköpta ljus till användaren
                    // Funkar inte om man använder en av de initiala användarna.. då tar den upp felmeddelandet från loginmethod? Men fungerar om man skapar en ny användare
                    CurrentUser.current.AddBoughtCandle(); // Måste gå via CurrentUser.current för att det ska registreras på den inloggade användaren. 
                    break;
                case 4:
                    // Metod för visa inloggad användares profil
                    // Funkar inte om man använder en av de initiala användarna.. då tar den upp felmeddelandet från loginmethod? Men fungerar om man skapar en ny användare
                    CurrentUser.current.PrintCurrentUser();
                    break;
                case 5:
                    // Metod för att ändra inloggad användares profil
                    EditUser.EditUserMethod();
                    break;
                case 6:
                    // Metod för att visa lista av alla användare
                    User.PrintUsers();
                    break;
                case 7:
                    // Avslutar programmet
                    ExitProgram.EndMessage(); 
                    break; 
                default: // Om userInput är en siffra som inte finns i menyvalet/casen
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
                    MainMenuMethod();
                    break;
            }


        }
    }
}

