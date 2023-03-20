using System;
using Agents.Logic.Interfaces;

namespace Agents.Logic.Operations 
{
	public class Mean : Response
	{

        public Mean(double[] array)
        {
            double promedio = array.Average();       
            result(promedio);
           
        }
    }
}

