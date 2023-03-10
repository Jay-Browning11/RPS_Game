using System.Runtime.CompilerServices;

class program
{
    static void Main(string[] args)
    {
       

        string inputPlayer, inputCPU; //setting variables that are used later in the code
        int randomint;
        bool playAgain = true;

        Console.WriteLine("Please Input Player Name:"); //sets the playerName variable to be used when refering to the player
        string playerName = Console.ReadLine();
        Console.Clear();
        
        while (playAgain = true) //repeats the whole game so long as the variable playAgain is true
        {
            int scorePlayer = 0; //sets both player and CPU scores to 0 at the beginning of the game
            int scoreCPU = 0;

            while (scorePlayer < 3 && scoreCPU < 3) //checks if either player or CPU has reached 3 points yet, repeats the game until someone wins
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choose ROCK, PAPER or SCISSORS (Best of three)"); //prompts player to choose one of the three options
                inputPlayer = Console.ReadLine();

                Random rnd = new Random(); //chooses a random option for the CPU

                randomint = rnd.Next(1, 4);

                if (inputPlayer == "ROCK" || inputPlayer == "SCISSORS" || inputPlayer == "PAPER") //only allows one of the three options to be input
                {
                    switch (randomint)
                    {
                        case 1:

                            inputCPU = "ROCK";
                            Console.ForegroundColor = ConsoleColor.Blue; //if player input and CPU input match it is a draw, no points awarded
                            Console.WriteLine("CPU chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("DRAW ({0} - {1} CPU - {2})", playerName, scorePlayer, scoreCPU); //shows the scores and the set player name
                            }
                            else if (inputPlayer == "PAPER") //if player wins, player gets a point
                            {
                                scorePlayer++;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("{0} WINS ({1} - {2} CPU - {3})", playerName, playerName, scorePlayer, scoreCPU);
                            }
                            else if (inputPlayer == "SCISSORS") //if CPU wins, CPU gets a point
                            {
                                scoreCPU++;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("CPU WINS ({0} - {1} CPU - {2})", playerName, scorePlayer, scoreCPU);
                            }

                            break;
                                        //This repeats for the other possible win, draw, lose conditions with the same code.
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
                else if (inputPlayer == "QUIT") //if the player inputs "QUIT" the program closes
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press ENTER to exit program");
                    System.Environment.Exit(0);
                }
                else //if the player doesn't input any of the specified commands, no points are awarded, invalid entry message.
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID ENTRY");
                }
            }

            if (scorePlayer == 3) //if the player gets 3 points, it gives the player the win message
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PLAYER WINS GAME");
            }
            else if (scoreCPU == 3) //if the CPU gets 3 points it gives the player the CPU win message
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("CPU WINS GAME");
            }

            Console.ForegroundColor = ConsoleColor.White; //The player is asked if they want to play again
            Console.WriteLine("Play Again? (Y/N)"); 
            string loop = Console.ReadLine();
            if (loop == "Y") //if Y is chosen, the while loop continues and the game starts again
            {
                playAgain = true;
                Console.Clear();
            }
            else if (loop == "N") //if N is chosen the while loop is broken and the game ends
            {
                playAgain = false;
            }
            }
           
        }
    }




