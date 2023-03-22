using System;
using Agents.Models;

namespace Agents.Logic.Interfaces
{
	public interface IAgentsLogic
	{
        bool getAgents(AgentsSettingsModel data);

        List<string> getOperations(AgentsSettingsModel data);

        void postAgents(List<string> operations, FactoryMethod factory);
    }
}

