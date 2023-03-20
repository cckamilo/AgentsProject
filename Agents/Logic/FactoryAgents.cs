using System;
using Agents.Logic.Interfaces;
using Agents.Logic.Operations;

namespace Agents.Logic
{
    public class FactoryAgents : FactoryMethod
    {
        public override Response getMedia(int agent, double[] items)
        {
            switch (agent)
            {
                case 1:            
                    return new Mean(items);
                case 2:
                    return new HarmonicMean(items);
                case 3:
                    return new Median(items);
                default:
                    return null;
            }
         
        }

        public override Response getStaircase(int agent, int value)
        {
            switch (agent)
            {
                case 1:
                    return new StairsA(value);
                case 2:
                    return new StairsB(value);
                case 3:
                    return new StairsC(value);
                default:
                    return null;
            }
        }
    }
}

