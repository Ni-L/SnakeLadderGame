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
            /// <summary>
            /// Rolls the dice.
            /// </summary>
            
                Console.WriteLine("WelCome To Snake And Ladder");
                int position = 0;//Initialize Position
                string player = "Player1";
                Random random = new Random();//generating random number
                int Dice = random.Next(1, 7);//Store random value in Dice
                Console.WriteLine(Dice);//Print Dice 
            }
        }
    }

