using GuessGame;
using System;
using System.Collections.Generic;
using System.Threading;
namespace Choose_Your_Class
{
    class Program : Bar
    {
        public static Game mygame = new Game();
        public static Bar myBar = new Bar();
        public static void Main(string[] args)
        {
            myBar.AddDrink(new Drink() { _DrinkName = "Dark and Stormy", _firstDrink = "Dark Rum", _secondDrink = "Ginger beer", _thirdDrink = "None", _garnish = "Lime" });

            bool stillPlaying = true;
            while (stillPlaying)
            {
                Console.WriteLine(" -----------");
                Console.WriteLine("|Micky's Bar|");
                Console.WriteLine(" -----------");
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("-=x=-=x=-=x=-=x=-=x=-=x=-=x=-");
                Console.WriteLine("1. Make drinks");
                Console.WriteLine("2. See list of drinks");
                Console.WriteLine("3. Play Heads or Tails");
                Console.WriteLine("4. WIP");
                Console.WriteLine("5. Q to quit");
                Console.WriteLine("-=x=-=x=-=x=-=x=-=x=-=x=-=x=-");
                string userInput = Console.ReadLine().ToLower();
                
                switch (userInput)
                {
                    case "1":
                        MakeDrinkMenu();
                        break;
                    case "2":
                        myBar.DrinkMenu();
                        break;
                    case "3":
                        mygame.Flip();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("########-it literally says Work In Progress-##########");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine(">:(");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "q":
                        stillPlaying = false;
                        break;
                }




                void MakeDrinkMenu()
                {
                    Console.Clear();
                    Console.WriteLine("-=x=-=x=-=x=-=x=-=x=-=x=-=x=-");
                    Console.WriteLine("Enter 1st drink mix");
                    string firstDrink = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("-=x=-=x=-=x=-=x=-=x=-=x=-=x=-");
                    Console.WriteLine("Enter 2rd drink mix");
                    string secondDrink = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("-=x=-=x=-=x=-=x=-=x=-=x=-=x=-");
                    Console.WriteLine("Enter 3rd drink mix");
                    string thirdDrink = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("-=x=-=x=-=x=-=x=-=x=-=x=-=x=-");
                    Console.WriteLine("does this drink have a garnish?/ if not enter no");
                    string garnish = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("-=x=-=x=-=x=-=x=-=x=-=x=-=x=-");
                    Console.WriteLine("name it!");
                    string name = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\nName of Drink: " + name + "\nFirst Mix: " + firstDrink + "\nSecond Mix: " + secondDrink + "\nThird Drink: " + thirdDrink + "\nGarnish: " + garnish);
                    Console.WriteLine("-=x=-=x=-=x=-=x=-=x=-=x=-=x=-");
                    Console.WriteLine("would you like to save this drink?");
                    Console.WriteLine("yes or no");
                    string userInput = Console.ReadLine().ToLower();
                    switch (userInput)
                    {
                        case "yes":
                            myBar.AddDrink(new Drink() { _DrinkName = name, _firstDrink = firstDrink, _secondDrink = secondDrink, _thirdDrink = thirdDrink, _garnish = garnish });
                            break;
                        case "no":
                            break;
                    }
                    Console.Clear();


















                }


            }
        }
    }
}
   










