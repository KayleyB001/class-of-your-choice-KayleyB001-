using System;

namespace GuessGame
{
    class Game
    {
        public  void Flip()
        {
            
            string[] choices = { "heads", "tails" };
            Console.Clear();
            Console.WriteLine("Heads or Tails");
            Random r = new Random();
            bool isFliping = false;
            int i = r.Next(0, 2);
            do
            {
                if (Console.ReadLine() != choices[i])
                {
                    Console.Clear();
                    Console.WriteLine($"Oof! It landed on {choices[1]}. Sad days....");
                    
                    i = r.Next(0, 2);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You won!");

                }
                Console.WriteLine("would you like to play again?");
                Console.WriteLine("yes or no");
                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "yes":
                        Console.Clear();
                        Flip();
                        break;
                    case "no":
                        Console.Clear();
                        isFliping = true;
                        break;

                     

                }
            } while (isFliping == false);
            Console.Clear();
            Console.WriteLine("Press any key to exit.");
            isFliping = true;
            Console.Clear();
        }
    }
}
