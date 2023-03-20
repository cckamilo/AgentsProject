using System;
using System.Linq;
using Agents.Logic.Interfaces;

namespace Agents.Logic.Operations
{
    public class Median : Response
    {      
        public Median(double[] array)
        {
            int total = array.Length / 2;
            double resultMedian = 0.0;
            if (array.Length % 2 == 0)
            {
                resultMedian = (float)(array[total - 1] + array[total]) / 2.0;
            }
            else
            {
                resultMedian = array[total];
            }
         
            result(resultMedian);

        }

    }
}

