using System.Runtime.CompilerServices;

class program
{
    static void Main(string[] args)
    {
       

        string inputPlayer, inputCPU;
        int randomint;
        bool playAgain = true;

        Console.WriteLine("Please Input Player Name:");
        string playerName = Console.ReadLine();
        Console.Clear();
        
        while (playAgain = true)
        {
            int scorePlayer = 0;
            int scoreCPU = 0;

            while (scorePlayer < 3 && scoreCPU < 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choose ROCK, PAPER or SCISSORS (Best of three)");
                inputPlayer = Console.ReadLine();

                Random rnd = new Random();

                randomint = rnd.Next(1, 4);

                if (inputPlayer == "ROCK" || inputPlayer == "SCISSORS" || inputPlayer == "PAPER")
                {
                    switch (randomint)
                    {
                        case 1:

                            inputCPU = "ROCK";
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("CPU chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("DRAW ({0} - {1} CPU - {2})", playerName, scorePlayer, scoreCPU);
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                scorePlayer++;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("{0} WINS ({1} - {2} CPU - {3})", playerName, playerName, scorePlayer, scoreCPU);
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                scoreCPU++;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("CPU WINS ({0} - {1} CPU - {2})", playerName, scorePlayer, scoreCPU);
                            }

                            break;

                        case 2:

                            inputCPU = "PAPER";
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("CPU chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("DRAW ({0} - {1} CPU - {2})", playerName, scorePlayer, scoreCPU);
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                scorePlayer++;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("{0} WINS ({1} - {2} CPU - {3})", playerName, playerName, scorePlayer, scoreCPU);
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                scoreCPU++;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("CPU WINS ({0} - {1} CPU - {2})", playerName, scorePlayer, scoreCPU);
                            }

                            break;

                        case 3:

                            inputCPU = "SCISSORS";
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("CPU chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("DRAW ({0} - {1} CPU - {2})", playerName, scorePlayer, scoreCPU);
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                scorePlayer++;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("{0} WINS ({1} - {2} CPU - {3})", playerName, playerName, scorePlayer, scoreCPU);
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                scoreCPU++;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("CPU WINS ({0} - {1} CPU - {2})", playerName, scorePlayer, scoreCPU);
                            }

                            break;

                        default:

                            Console.WriteLine("INVALID ENTRY");

                            break;
                    }
                }
                else if (inputPlayer == "QUIT")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press ENTER to exit program");
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID ENTRY");
                }
            }

            if (scorePlayer == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PLAYER WINS GAME");
            }
            else if (scoreCPU == 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("CPU WINS GAME");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Play Again? (Y/N)");
            string loop = Console.ReadLine();
            if (loop == "Y")
            {
                playAgain = true;
                Console.Clear();
            }
            else if (loop == "N")
            {
                playAgain = false;
            }
            }
           
        }
    }




