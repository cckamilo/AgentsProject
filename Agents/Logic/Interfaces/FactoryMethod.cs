using System;
namespace Agents.Logic.Interfaces
{
	public abstract class FactoryMethod
	{

		public abstract Response getMedia(int agent, double[] items);

        public abstract Response getStaircase(int agent, int value);

    }
}

