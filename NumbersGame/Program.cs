//LUDWIG OLEBY SUT21

using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {

            gameLoop();

        } // Main slutar


        static void gameLoop()
        {
            
            bool gameOver = false;

            while (gameOver == false) //Spel loop
            {
                Console.Clear();
                Console.WriteLine("Välkomen! välj hur många siffror det skall finnas att gissa på: ");
            int totalNumbers = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Välj hur många försök du skall få");
            int totalTries = Int32.Parse(Console.ReadLine());
            Random random = new Random();
            
                int number = random.Next(1, totalNumbers);
                int tries = 0;
                int userGuess = 0;

                while (userGuess != number && tries !=totalTries)

                {
                    Console.WriteLine("Gissa ett tal mellan 1 och " + totalNumbers);
                    userGuess = Int32.Parse(Console.ReadLine());

                    if (userGuess < number)
                    {
                        Console.WriteLine("Tyvärr du gissade för lågt!");
                        tries++;
                    }

                    if (userGuess > number)
                    {
                        Console.WriteLine("Tyvärr du gissade för Högt!");
                        tries++;
                    }

                    if (tries == totalTries)
                    {
                        Console.WriteLine("Tyvärr du lyckades inte gissa talet på " + totalTries + " försök! \n" + "Rätt nummer var: " + number);
                        replay(gameOver);
                    }

                    if (userGuess == number)
                    {
                        Console.WriteLine("Woho! Du gjorde det!");
                        replay(gameOver);
                    }
                }
            }// Spel loop slutar


                     
        }

        public static void replay(bool gameOver)
        {
            
            Console.WriteLine("Vill du spela igen? Ja/Nej ");
            string replay = Console.ReadLine();
            if (replay == "ja")
            {
                gameOver = false;
            }
            else
            {
                gameOver = true;
                Console.WriteLine("Tack för att du spelade! \n tryck på valfri tangent för att avsluta . . .");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }
    }
}