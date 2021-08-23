using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
       
            while (isRunning)
            {
                Console.WriteLine("\n\tGISSA NUMRET");
                Console.Write("\n\t[1]SPELA");
                Console.WriteLine("\n\t[2]AVSLUTA");

                int menyVal = Convert.ToInt32(Console.ReadLine());

                try
                {
                    switch (menyVal)
                    {
                        case 1:
                            Random rd = new Random();
                            int rand_num = rd.Next(1, 101);
                            int guess;
                            int noOfGuesses = 5;
                            bool gameover = false;

                            Console.WriteLine("\n\nGissa på ett nummer mellan 1 och 100. Du har fem försök att gissa rätt.");
                            noOfGuesses--;

                            while (gameover == false)
                            {
                                guess = Convert.ToInt32(Console.ReadLine());

                                if (guess < 1 || guess > 100)
                                {
                                    Console.WriteLine("\nBara tal mellan 1 och 100! Försök igen!");
                                    Console.ReadLine();
                                }

                                if (guess != rand_num && noOfGuesses == 0)
                                {
                                    Console.WriteLine("\nSpelet är slut och du kan inte gissa fler gånger. Talet jag tänkte på var: " + rand_num.ToString());
                                    gameover = true;
                                }
                                else if (guess == rand_num)
                                {
                                    Console.WriteLine("\nDet är rätt gissat. DU VINNER!");
                                    gameover = true;
                                }
                                else if (guess > rand_num)
                                {
                                    noOfGuesses--;
                                    Console.WriteLine("\nTalet är för högt. Försök igen!");
                                }
                                else if (guess < rand_num)
                                {
                                    noOfGuesses--;
                                    Console.WriteLine("\nTalet är för lågt. Försök igen!");
                                }
                            }
                            Console.ReadLine();
                            break;

                        case 2:
                            isRunning = false;
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("\n\tFel format! Du kan bara ange heltal. Åter till menyn.");
                    continue;
                }
            }
        }
    }
}
