using System;
using Agents.Logic.Interfaces;

namespace Agents.Logic.Operations
{
	public class StairsC: Response
	{
		public StairsC(int value)
		{

            //Arriba
            //Se agrega una nueva linea 
            for (int stairNumber = 1; stairNumber <= value + 1; stairNumber++)
            {
                for (int i = 1; i <= (value + 1) - stairNumber; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 1; i <= stairNumber ; i++)
                {
                    Console.Write("*");
                }
                for (int i = 0; i < stairNumber - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            //Abajo
            for (int stairNumber = value; stairNumber > 0; stairNumber--)
            {
                for (int i = 0; i <= (value - stairNumber); i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < stairNumber; i++)
                {
                    Console.Write("*");

                }
                for (int i = 0; i < stairNumber - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
	}
}

