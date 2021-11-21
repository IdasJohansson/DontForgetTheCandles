using System;
using System.Collections.Generic;
using System.Linq;
using DontForgetTheCandles.Class;

namespace DontForgetTheCandles.Method
{
    public class AddUser
    {
     
        public static void AddUserByInput()
        {
            try
            {
                Console.Clear();
                int id = User.users.Count() + 1; // Tilldelar användaren ett användarId enligt vilken plats den får i listan, vilket blir 5 eftersom vi har fyra inlagda användare i systemet. 
                Console.WriteLine("\nYour ID: {0}", id);
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter city: ");
                string city = Console.ReadLine();
                int nrOfLights = 0;
                int boughtLights = 0;
                CurrentUser.current = new User(id, name, age, city, nrOfLights, boughtLights);
            }
            catch (Exception)
            {
                Console.Clear();
                ConsoleColor prevColor = Console.ForegroundColor; // Sparar nuvarande textfärg i variablen prevColor
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n* * * * * * * * * * * * * * * *");
                Console.WriteLine("!ERROR!");
                Console.WriteLine("Wrong input");
                Console.WriteLine("Press a key and try again :)(:");
                Console.WriteLine("* * * * * * * * * * * * * * * *");
                Console.ForegroundColor = prevColor; // Byter tillbaka prevColor
                Console.ReadKey();
                Console.Clear();
                AddUserByInput(); 
            }

            MainMenu.MainMenuMethod(); // Skickar vidare till huvudmenyn

        }
        
    }
}
