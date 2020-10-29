using System;
using System.Runtime.CompilerServices;

namespace TicTacToe
{
    class Game
    {
        /*
         * Program meant to simulate Tic Tac Toe with two users.
         * Field is standard 3 x 3 Tic Tac Toe Field
         * When a player has one, the program will display the winner
         * and terminate. There are methods to check winning status, if the
         * user's input is parseable (an actual number between 1 and 9), and if
         * a space is available or already occupied. 
         */

        private static char[,] gameField = new char[,]
        {
            {'1', '2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };

        private static string choice;

        public static void Main(string[] args)
        {
            PlayGame();
        }

        public static void DisplayField()
        {
            Console.WriteLine(gameField[0,0] + "\t|\t" + gameField[0,1] + "\t|\t" + gameField[0,2]);
            Console.WriteLine("--------|---------------|---------");
            Console.WriteLine(gameField[1,0] + "\t|\t" + gameField[1,1] + "\t|\t" + gameField[1,2]);
            Console.WriteLine("--------|---------------|---------");
            Console.WriteLine(gameField[2,0] + "\t|\t" + gameField[2,1] + "\t|\t" + gameField[2,2]);
        }

        public static void PlayGame()
        {
            int player = 2;
            int input = 0;
            bool winCheck = true;
            int counter = 1;

            do
            {

                counter++;
                
                if (player == 2)
                {
                    player = 1;
                } else if (player == 1)
                {
                    player = 2;
                }
                
                DisplayField();

                Console.WriteLine("Player {0}, please enter your choice (1-9)", player);

                while (true)
                {
                    
                    choice = Console.ReadLine();
                    bool breakOut = true;
                    while (breakOut)
                    {
                        bool isParseable = IsParseable(choice);
                        if (isParseable)
                        {
                            input = int.Parse(choice);
                            breakOut = false;
                        }
                        else
                        {
                            Console.WriteLine("That is not a parseable value, try again!");
                            choice = Console.ReadLine();
                        }
                    }
                    
                    if (input >= 1 && input <= 9)
                    {
                        switch (player)
                        {
                            case 1:
                                switch (input)
                                {
                                    case 1:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 2:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 3:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 4:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 5:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 6:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 7:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 8:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 9:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;


                                }

                                break;

                            case 2:
                                switch (input)
                                {
                                    case 1:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 2:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 3:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 4:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 5:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 6:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 7:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 8:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;

                                    case 9:
                                        if (CheckSpace())
                                        {
                                            XOrO(choice, player);
                                        }

                                        break;
                                }

                                break;
                        }

                        break;
                    }
                    Console.WriteLine("Please enter a number between 1-9, try again!");
                }

                if (CheckWin())
                {
                    Console.WriteLine("Player {0} has won the game!", player);
                    DisplayField();
                    winCheck = false;
                }

                if (counter == 10)
                {
                    Console.WriteLine("Game is a draw!");
                    winCheck = false;
                }

            } while (winCheck);
        }

        public static bool IsParseable(string choice)
        {
            int input;
            if (int.TryParse(choice, out input))
            {
                return true;
            }

            return false;
        }

        public static bool CheckSpace()
        {
            do
            {
                foreach (char c in gameField)
                {
                    if (c.Equals(choice[0]))
                    {
                        Console.WriteLine("Space {0} is now taken", c);
                        return true;
                    }
                }
                
                Console.WriteLine("Space is already occupied, try again!");
                choice = Console.ReadLine();

            } while (true);
        }

        public static void XOrO(string choice, int player)
        {
            char input;
            if (player == 1)
            {
                input = 'X';
            } else
            {
                input = 'O';
            }

            for (int i = 0; i <= gameField.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= gameField.GetUpperBound(1); j++)
                {
                    if (gameField[i,j].Equals(choice[0]))
                    {
                        gameField[i, j] = input;
                    }
                }
            }
        }

        public static bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (TriCheck(gameField[i, 0], gameField[i, 1], gameField[i, 2]))
                {
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (TriCheck(gameField[0, i], gameField[1, i], gameField[2, i]))
                {
                    return true;
                }
            }

            if (TriCheck(gameField[0, 0], gameField[1, 1], gameField[2, 2]))
            {
                return true;
            }

            if (TriCheck(gameField[2, 0], gameField[1, 1], gameField[0, 2]))
            {
                return true;
            }

            return false;
        }

        public static bool TriCheck(char one, char two, char three)
        {
            if ((one == two) && (one == three))
            {
                return true;
            }

            return false;
        }
    }
}