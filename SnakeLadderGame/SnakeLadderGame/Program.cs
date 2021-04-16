using System;

namespace SnakeLadderGame
{
    class Program
    {
        /// <summary>
        /// Creating Program for Position =0
        /// </summary>

        static void Main(string[] args)
        {
            int position = 0;
            string player = "Player1";

            while (position < 100)
            {
                Random random = new Random();//Generating Random Number
                int Dice = random.Next(1, 7);//It will create 1,2,3,4,5,6 Random Number and store in Dice
                Console.WriteLine("value on the Dice" + Dice);
                Random random1 = new Random();
                int check = random1.Next(0, 3);//Creating Random Number for Check Option

                if (check == 0)
                {
                    Console.WriteLine("Their is No Play");
                }
                else if (check == 1)
                {
                    Console.WriteLine("You get Ladder");
                    position = position + Dice;
                }
                else if (check == 2)
                {
                    Console.WriteLine("You get Snake");
                    position = position - Dice;
                }
                if (position < 0)
                {
                    position = 0;
                }
                Console.WriteLine(position);
            }
            Console.WriteLine("You Are Winner");
        }
    }
}


