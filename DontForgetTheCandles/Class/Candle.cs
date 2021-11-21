using System;
using System.Collections.Generic;
using DontForgetTheCandles.Method; 

namespace DontForgetTheCandles
{
    public class Candle
    {
        // Klassen innehåller: Fields, Properties, Lista, Konstruktor

        // Fields, info om ljusen
        private DateTime _candleLighted = DateTime.Now; // När man registrerar att man tänder ljuset registreras tiden nu.
        private string _byUser; // Vilken user som registrerat ljuset registreras på användarnamn. 
        private string _room; // Vilket rum du har tänt ljuset i.
        private double _burnHours; // Antal timmar ljuset brinner
        private DateTime _lightOut; // När ljuser slocknar.

        // Properties för att komma åt fieldsen utanför klassen
        public DateTime CandleLighted
        { get { return _candleLighted; } set { _candleLighted = value;} }
        public string ByUser
        { get { return _byUser; } set { _byUser = value; } }
        public string Room
        { get { return _room; } set { _room = value; } }
        public double BurnHours
        { get { return _burnHours; } set { _burnHours = value; } }
        public DateTime LightOut
        { get { return _lightOut; } set { _lightOut = value; } }

        // Lista med alla candles
        public static List<Candle> candles = new List<Candle>();

        // Konstruktor med alla värden som lägger till alla objekt vi skapar av klassen candle i en lista
        public Candle(DateTime candleLighted, string byUser, string room, double burnHours, DateTime lightOut)
        {
            this._candleLighted = candleLighted;
            this._byUser = byUser; 
            this._room = room;
            this._burnHours = burnHours;
            this._lightOut = lightOut; 
            candles.Add(this); 
        }

        public static void PrintListWithCandles()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("LIST OF ALL CANDLES: ");
            foreach (var candle in candles)
            {
                Console.WriteLine();
                Console.WriteLine("Candle registerd by: {0}", candle.ByUser);
                Console.WriteLine("Candle lighted: {0}", candle.CandleLighted);
                Console.WriteLine("Room: {0}", candle.Room);
                Console.WriteLine("Burn hours: {0}", candle.BurnHours);
                Console.WriteLine("Candle will burn out: {0}", candle.LightOut);
                Console.WriteLine();
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("Press any key to return to Main Menu...");
            Console.ReadKey();
            Console.Clear();
            MainMenu.MainMenuMethod();
        }
    }
}
