using System;

namespace DontForgetTheCandles.Method
{
    public class ExitProgram
    {
        // Hejdå meddelande som spelas upp om användaren väljer "Exit program"
        public static void EndMessage(string text = "THANK YOU FOR USING THIS PROGRAM, HAVE A GREAT DAY :)", int delay = 100)
        {
            Console.Clear();
            Console.WriteLine();
            for (int i = 0; i < text.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow; // Byter färg på texten till gul
                Console.Write(text[i]);
                System.Threading.Thread.Sleep(delay);
               
                // För att hoppa över animationen och få texten utskriven direkt genom att trycka på enter
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.Write(text.Substring(i + 1));
                        break;
                    }
                }
            }
        }
    }
}
