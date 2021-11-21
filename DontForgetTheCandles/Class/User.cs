using System;
using System.Collections.Generic;
using DontForgetTheCandles.Method;
using DontForgetTheCandles.Class; 

namespace DontForgetTheCandles
{
    public class User
    {
        // Klassen innehåller: Fields, Properties, Lista, Konstruktor

        // Fields, info om users
        private int _id; 
        private string _name;
        private int _age;
        private string _city;
        private int _nrOfLights; // Tända ljus
        private int _boughtCandle; // Köpta ljus

        // Properties för att komma åt fieldsen utanför klassen
        public int ID
        { get { return _id; } set { _id = value; } }

        public string Name
        { get { return _name; } set { _name = value; } }

        public int Age
        { get { return _age; } set { _age = value; } }

        public string City
        { get { return _city; } set { _city = value; } }

        public int NrOfLights
        { get { return _nrOfLights; } set { _nrOfLights = value; } }

        public int BoughtCandle
        { get { return _boughtCandle; } set { _boughtCandle = value; } }

        // Lista med alla users
        public static List<User> users = new List<User>(); 

        // Konstruktor med alla värden som lägger till alla objekt vi skapar av klassen user i en lista
        public User(int id, string name, int age, string city, int nrOfLights, int boughtCandle)
        {
            this._id = id;
            this._name = name;
            this._age = age;
            this._city = city;
            this._nrOfLights = nrOfLights;
            this._boughtCandle = boughtCandle;
            users.Add(this); // Adderar alla users som använder denna konstruktorn till listan users
        }

        public void PrintCurrentUser() // Skriver ut info om inloggad användare
        {
            Console.Clear(); 
            Console.WriteLine();
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("City: {0}", City);
            Console.WriteLine("Lighted candels: {0}", NrOfLights);
            Console.WriteLine("Bought candles: {0}", BoughtCandle);
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to Main Menu...");
            Console.ReadKey();
            Console.Clear();
            MainMenu.MainMenuMethod();
        }


        public static void PrintUsers() // Skriver ut all info om alla users 
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("LIST OF ALL USERS: ");
            foreach (var user in users)
            {
                Console.WriteLine();
                Console.WriteLine("ID: {0}", user.ID);
                Console.WriteLine("Name: {0}", user.Name);
                Console.WriteLine("Age: {0}", user.Age);
                Console.WriteLine("City: {0}", user.City);
                Console.WriteLine("Lighted candels: {0}", user.NrOfLights);
                Console.WriteLine("Bought candles: {0}", user.BoughtCandle);
                Console.WriteLine();
                Console.WriteLine("-----------------------");
            }
           
            Console.WriteLine("Press any key to return to Main Menu...");
            Console.ReadKey();
            Console.Clear();
            MainMenu.MainMenuMethod();
        }


        public void AddBoughtCandle()
        {
            Console.Clear(); 
            BoughtCandle++;
            Console.WriteLine();
            Console.WriteLine("You have added {0} candle to list of bought candles.", BoughtCandle);
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadKey();
            Console.Clear(); 
            MainMenu.MainMenuMethod(); 
        }


    }
}
