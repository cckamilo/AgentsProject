using System;
using Agents.Logic.Interfaces;

namespace Agents.Logic.Operations
{
    public class StairsB : Response
    {
        public StairsB(int value)
        {
            for (int stairNumber = value; stairNumber >= 0; stairNumber--)
            {

                for (int i = 0; i <= (value - stairNumber - 1 ) ; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < stairNumber; i++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }
        }
    }
}

