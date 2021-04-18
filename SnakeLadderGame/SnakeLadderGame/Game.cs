using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    class Game
    {
            //constant
            const int START_POSITION = 0;
            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            const int WINNING_POSITION = 100;
            public void Play()
            {
                int[] player = new int[2] { 0, 0 };
                int dieCount = 0;
                int chance = 0;
                while (player[chance] < WINNING_POSITION)
                {
                    Random random = new Random();
                    int option = random.Next(0, 3);
                    int dieValue = random.Next(1, 7);
                    dieCount++;

                    switch (option)
                    {
                        case NO_PLAY:
                            Console.WriteLine("No Play, Pass the chance");
                            break;
                        case LADDER:
                            if (player[chance] + dieValue <= WINNING_POSITION)
                            {
                                player[chance] += dieValue;
                            }
                            Console.WriteLine("You got Ladder \n player = " + chance + "->" + " position " + "  " + player[chance]);
                            break;
                        case SNAKE:
                            if (player[chance] - dieValue < START_POSITION)
                            {
                                player[chance] = START_POSITION;
                            }
                            else
                            {
                                player[chance] -= dieValue;
                            }
                            Console.WriteLine("You gotSnake \n player = " + chance + "-> position " + " " + player[chance]);
                            break;
                        default:
                            break;
                    }
                    if (option == NO_PLAY || option == SNAKE)
                    {
                        if (chance == 0)
                            chance = 1;
                        else
                            chance = 0;
                    }
                }
                Console.WriteLine("Total number of times die was rolled : " + dieCount);
            }
    }
}

