using System;
using System.Collections.Generic;

namespace learning
{
    class Program
    {
        static string[,] fields =
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"}
        };
        static bool[,] playedFields =
        {
            {false, false, false},
            {false, false, false},
            {false, false, false}
        };
        static int playing = 1;
        static int winner = 0;

        static void Main(string[] args)
        {
            string input;

            Start:

            do
            {
                Console.Clear();
                Console.WriteLine("     |     |\n" +
                "  {0}  |  {1}  |  {2}", fields[0,0], fields[0,1], fields[0,2] +
                "\n_____|_____|_____");
                Console.WriteLine("     |     |\n" +
                "  {0}  |  {1}  |  {2}", fields[1,0], fields[1,1], fields[1,2] +
                "\n_____|_____|_____");
                Console.WriteLine("     |     |\n" +
                "  {0}  |  {1}  |  {2}", fields[2,0], fields[2,1], fields[2,2] +
                "\n     |     |     ");

                winner = WhoIsWinner();

                if(winner != 0)
                    break;

                Console.WriteLine("Player {0}, choose a field", playing);
                input = Console.ReadLine();

                Play(input);
            } while(winner==0);

            if(winner == 3)
                Console.WriteLine("It's a tie!! No winners!");
            else
                Console.WriteLine("Player {0} is the winner!", winner);

            Console.WriteLine("Enter 'yes' to play again or anything else to quit application.");
            string again = Console.ReadLine();
            if(again.ToLower() == "yes")
            {
                fields = new string [,] {{"1", "2", "3"},{"4", "5", "6"},{"7", "8", "9"}};
                playedFields = new bool [,] {{false, false, false},{false, false, false},{false, false, false}};
                playing = 1;
                winner = 0;
                goto Start;
            }
            Console.WriteLine("Thank you for playing!");
            Console.ReadKey();
        }

        static void Play(string play)
        {
            switch(play)
            {
                case "1":
                    if(!playedFields[0,0])
                    {
                        if(playing == 1)
                        {
                            fields[0,0] = "X";
                            playing = 2;
                        }
                        else
                        {
                            fields[0,0] = "O";
                            playing = 1;
                        }
                        playedFields[0,0] = true;
                        return;
                    } else
                        break;

                case "2":
                    if(!playedFields[0,1])
                    {
                        if(playing == 1)
                        {
                            fields[0,1] = "X";
                            playing = 2;
                        }
                        else
                        {
                            fields[0,1] = "O";
                            playing = 1;
                        }
                        playedFields[0,1] = true;
                        return;
                    } else
                        break;

                
                case "3":
                    if(!playedFields[0,2])
                    {
                        if(playing == 1)
                        {
                            fields[0,2] = "X";
                            playing = 2;
                        }
                        else
                        {
                            fields[0,2] = "O";
                            playing = 1;
                        }
                        playedFields[0,2] = true;
                        return;
                    } else
                        break;


                case "4":
                    if(!playedFields[1,0])
                    {
                        if(playing == 1)
                        {
                            fields[1,0] = "X";
                            playing = 2;
                        }
                        else
                        {
                            fields[1,0] = "O";
                            playing = 1;
                        }
                        playedFields[1,0] = true;
                        return;
                    } else
                        break;

                case "5":
                    if(!playedFields[1,1])
                    {
                        if(playing == 1)
                        {
                            fields[1,1] = "X";
                            playing = 2;
                        }
                        else
                        {
                            fields[1,1] = "O";
                            playing = 1;
                        }
                        playedFields[1,1] = true;
                        return;
                    } else
                        break;

                case "6":
                    if(!playedFields[1,2])
                    {
                        if(playing == 1)
                        {
                            fields[1,2] = "X";
                            playing = 2;
                        }
                        else
                        {
                            fields[1,2] = "O";
                            playing = 1;
                        }
                        playedFields[1,2] = true;
                        return;
                    } else
                        break;
                
                case "7":
                    if(!playedFields[2,0])
                    {
                        if(playing == 1)
                        {
                            fields[2,0] = "X";
                            playing = 2;
                        }
                        else
                        {
                            fields[2,0] = "O";
                            playing = 1;
                        }
                        playedFields[2,0] = true;
                        return;
                    } else
                        break;

                case "8":
                    if(!playedFields[2,1])
                    {
                        if(playing == 1)
                        {
                            fields[2,1] = "X";
                            playing = 2;
                        }
                        else
                        {
                            fields[2,1] = "O";
                            playing = 1;
                        }
                        playedFields[2,1] = true;
                        return;
                    } else
                        break;

                case "9":
                    if(!playedFields[2,2])
                    {
                        if(playing == 1)
                        {
                            fields[2,2] = "X";
                            playing = 2;
                        }
                        else
                        {
                            fields[2,2] = "O";
                            playing = 1;
                        }
                        playedFields[2,2] = true;
                        return;
                    } else
                        break;

                default:
                    Console.WriteLine("You should enter only one number!");
                    Console.ReadKey();
                    return;
                    //throw this error if user enter more than one number or a string
            }
            Console.WriteLine("This field was already played! Try again.");
            Console.ReadKey();
        }

        static int WhoIsWinner()
        {
            if((fields[0,2]  == "X" && fields[2,0] == "X")
            || (fields[0,0]  == "X" && fields[2,2] == "X")
            && fields[1,1] == "X")
                return 1;
            else if((fields[0,2]  == "O" && fields[2,0] == "O")
            || (fields[0,0]  == "O" && fields[2,2] == "O")
            && fields[1,1] == "O")
                return 2;

            for(int i = 0; i < 3; i++)
            {
                if((fields[i,0]  == "X" && fields[i,1] == "X" && fields[i,2] == "X")
                || (fields[0,i]  == "X" && fields[1,i] == "X" && fields[2,i] == "X"))
                    return 1;
                else if((fields[i,0]  == "O" && fields[i,1] == "O" && fields[i,2] == "O")
                || (fields[0,i]  == "O" && fields[1,i] == "O" && fields[2,i] == "O"))
                    return 2;
            }

            if (AllTrue())
                return 3;
            
            return 0;
        }

        static bool AllTrue()
        {
            int allTrue = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int y = 0; y < 3; y++)
                {
                    if(playedFields[i,y])
                    {
                        allTrue++;
                    } else
                        return false;
                }
            }
            if(allTrue != 9)
            {
                return false;
            }
            return true;
        }
    }
}