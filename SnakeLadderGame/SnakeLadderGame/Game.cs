using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    //Creating Game Classof Two Players
    class Game
    {
            //Create constant of Variables
            const int START_POSITION = 0;
            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            const int WINNING_POSITION = 100;
            //Adding Method Play
            public void Play()
            {
                int[] player = new int[2] { 0, 0 };//Creating Object
                int dieCount = 0;//for die Count
                int chance = 0;//for chance
                while (player[chance] < WINNING_POSITION)
                {
                    Random random = new Random();//Adding object of Random Class
                    int option = random.Next(0, 3);//Random Values to be 0,1,2.
                    int dieValue = random.Next(1, 7);//Random Values to be 1 to 7.
                    //for incrementing dieCount Value
                    dieCount++;

                    switch (option)//Switch for the Option 
                    {
                        case NO_PLAY:
                            Console.WriteLine("No Play, Pass the chance");//No Play and Pass Chance to Another Player
                            break;
                        case LADDER:
                            if (player[chance] + dieValue <= WINNING_POSITION)//You get Ladder then Adding Dievalue
                            {
                                player[chance] += dieValue;
                            }
                            Console.WriteLine("You got Ladder \n player = " + chance + "->" + " position " + "  " + player[chance]);
                            break;
                        case SNAKE:
                            if (player[chance] - dieValue < START_POSITION)//Get Snake And Minus Value
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

