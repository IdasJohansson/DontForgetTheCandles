using System;
using DontForgetTheCandles.Method;
using DontForgetTheCandles.Class; 

namespace DontForgetTheCandles
{
    class Program
    {
        static void Main(string[] args)
        {

            // About:
            // Keep track of your lighted candles...
            // Simple program where you can register a lighted candle and keep track of when they will burn out.
            // You can log in or create new user.
            // View logged in user and edit user detalis.
            // View list of users and view list of candles.
            // Add purchased candle to a counter that increases by one.
            // Exit program in different menus.

            StartScreen.InitialUsers();
            StartScreen.InitialCandels();

            StartScreen.StartMenu();




        }
    }
}
