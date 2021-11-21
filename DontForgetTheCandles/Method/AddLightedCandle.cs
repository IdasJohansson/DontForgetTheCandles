using System;
using DontForgetTheCandles.Class;

namespace DontForgetTheCandles.Method
{
    public class AddLightedCandle
    {

        public static void AddLightedCandleMethod()
        {
            try
            {
                Console.Clear();
                Console.WriteLine();
                string byUser = CurrentUser.current.Name;
                DateTime candleLighted = DateTime.Now;
                Console.WriteLine("Candle lighted: {0}", candleLighted);
                Console.WriteLine("By user: {0}", byUser);

                Console.Write("Enter room: ");
                string room = Console.ReadLine();

                Console.Write("Enter burn hours: ");
                double burnHours = Convert.ToDouble(Console.ReadLine());

                DateTime lightOut = candleLighted.AddHours(burnHours);
                Console.WriteLine("Candle will burn out: {0}", lightOut);

                new Candle(candleLighted: candleLighted, byUser: byUser, room: room, burnHours: burnHours, lightOut: lightOut);
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
                AddLightedCandleMethod(); 
            }

            MainMenu.MainMenuMethod(); 

        }

    }
}
