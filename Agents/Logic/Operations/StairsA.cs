using System;
using Agents.Logic.Interfaces;

namespace Agents.Logic.Operations
{
	public class StairsA : Response
	{
		public StairsA(int value)
		{
            
            for (int stairNumber = 0; stairNumber < value; stairNumber++)
            {
                for (int i = 0; i <= (value - stairNumber - 1); i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i <= stairNumber; i++)
                {
                   Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}

