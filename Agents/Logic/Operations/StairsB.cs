using System;
using Agents.Logic.Interfaces;

namespace Agents.Logic.Operations
{
	public class StairsB: Response
	{
		public StairsB( int value)
		{
			  for (int stairNumber = 1; stairNumber <= value; stairNumber++)
            {
                for (int i = 1; i <= stairNumber; i++)
                {
                   Console.Write("*");
                }
                Console.WriteLine("");
            }
		}
	}
}

