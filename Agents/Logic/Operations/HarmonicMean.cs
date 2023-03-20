using System;
using Agents.Logic.Interfaces;

namespace Agents.Logic.Operations
{
	public class HarmonicMean : Response
	{
        public double accumulate;

        public HarmonicMean(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                accumulate = accumulate + (1 / array[i]);
            }
            var h = array.Length / accumulate;

            result(h);
        }
    }
}

