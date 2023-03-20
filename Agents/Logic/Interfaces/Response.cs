using System;
using Agents.Logic.Operations;

namespace Agents.Logic.Interfaces
{
	public abstract class Response
	{
	
		public void result(double result)
		{
           
                Console.WriteLine(string.Format("La resultado es: " + result));
            
                  
		}
	}
}

