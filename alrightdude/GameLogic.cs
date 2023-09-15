using System;
using System.Threading;

namespace guessingGame
{
    class GameLogic
    {
        public void Run()
        {
            Random easy = new Random();
            int random;
            string response;
            bool playGame = true;
            int guess = 0;
            int numGuesses = 0;
            response = "";
            int gamesplayed = 0;
            int dummesiechMoves = -1;

            var Satz6 = "Ich han e nummer i mim Kopf vo 1-100. Wenn die erratisch ei Kuss :)";

            foreach (var character in Satz6)
            {
                Console.Write(character);
                Thread.Sleep(20);
            }
            Thread.Sleep(1000);
            Console.WriteLine();

            while (playGame)
            {
                try
                {
                    numGuesses = 1;
                    guess = 0;
                    response = "";
                    random = easy.Next(1, 100);

                    if (gamesplayed >= 1)
                    {
                        var Satz4 = "Chum nomal bigbro <3" + Environment.NewLine + "Rate nomal vo 1-100";

                        foreach (var character in Satz4)
                        {
                            Console.Write(character);
                            Thread.Sleep(20);
                        }

                        Console.WriteLine();
                    }

                    while (guess != random)
                    {
                        guess = Convert.ToInt32(Console.ReadLine());

                        if (dummesiechMoves == 1)
                        {
                            dummesiechMoves = 1;
                            Thread.Sleep(1600);
                            var Satz19 = "bro mach kei scheiss jz";

                            foreach (var character in Satz19)
                            {
                                Console.Write(character);
                                Thread.Sleep(40);
                            }
                            Console.WriteLine();
                        }
                        if (dummesiechMoves == 2)
                        {
                            Thread.Sleep(2000);
                            var Satz14 = "kolleg..." + Environment.NewLine + "nah bro ich han eif kb meh";

                            foreach (var character in Satz14)
                            {
                                Console.Write(character);
                                Thread.Sleep(40);
                            }
                            Console.WriteLine();
                            break;
                        }
                        else if (guess > 100)
                        {
                            dummesiechMoves++;
                            var Satz18 = "KOLLEG ICH SEGE VO 1-100 AMIGO" + Environment.NewLine + "KOMPLETT LOSTE SIECH";

                            foreach (var character in Satz18)
                            {
                                Console.Write(character);
                                Thread.Sleep(50);
                            }
                            Thread.Sleep(500);
                            Console.WriteLine();
                        }
                        else if (guess > random)
                        {
                            numGuesses++;
                            Console.WriteLine("Nah zu hoch");
                        }
                        else if (guess < random)
                        {
                            numGuesses++;
                            Console.WriteLine("Nah zu chli");
                        }
                    }

                    if (numGuesses <= 1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("WASSSSS???? FIRST TRY????");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                    }
                    else if (numGuesses > 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        var fertig = "Ja easy nach " + (numGuesses) + " mal hesch errate";

                        foreach (var character in fertig)
                        {
                            Console.Write(character);
                            Thread.Sleep(20);
                        }
                        Console.WriteLine();
                        Thread.Sleep(3000);
                        Console.ResetColor();
                    }

                    gamesplayed++;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    var Satz3 = "Wotsch nomal?" + Environment.NewLine + "schrib entweder Y (ja) oder N (nah)";

                    foreach (var character in Satz3)
                    {
                        Console.Write(character);
                        Thread.Sleep(20);
                    }
                    Console.ResetColor();
                    Console.WriteLine();
                    response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "Y")
                    {
                        playGame = true;
                    }
                    else
                    {
                        playGame = false;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        var ENding = "Ja easy bro unsympathische siech";

                        foreach (var character in ENding)
                        {
                            Console.Write(character);
                            Thread.Sleep(40);
                        }
                        Console.ResetColor();
                    }
                }
                catch (System.FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    var Satz5 = "Ich sege Zahl und du chunnsch mit Buechstabe..." + Environment.NewLine + "Probier nomal dumme siech";

                    foreach (var character in Satz5)
                    {
                        Console.Write(character);
                        Thread.Sleep(20);
                    }
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
        }
    }
}
