using System;
using Agents.Logic.Interfaces;

namespace Agents.Logic.Operations
{
	public class StairsA : Response
	{
		public StairsA(int value)
		{
            
            for (int stairNumber = 1; stairNumber <= value; stairNumber++)
            {
                for (int i = 1; i <= value - stairNumber; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 1; i <= stairNumber; i++)
                {
                   Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}

