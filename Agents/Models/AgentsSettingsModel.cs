using System;
namespace Agents.Models
{
    public class AgentsSettingsModel
    {
        const string idAgentA = "A";
        const string nameAgentA = "AgentA";
        List<string> operationAgentA = new List<string> { "Mean", "Stairs"};

        const string idAgentB = "B";
        const string nameAgentB = "AgentB";
        List<string> operationAgentB = new List<string> { "HarmonicMean", "Stairs" };

        const string idAgentC = "C";
        const string nameAgentC = "AgentC";
        List<string> operationAgentC = new List<string> { "Median", "Stairs" };

        public List<AgentsModel> agentsModel { get; set; }

        public AgentsSettingsModel()
        {
            agentsModel = new List<AgentsModel>()
                {
                    new AgentsModel()
                    {
                        id = idAgentA,
                        name = nameAgentA,
                        operations = operationAgentA
                    },
                    new AgentsModel()
                    {
                        id = idAgentB,
                        name = nameAgentB,
                        operations = operationAgentB
                    },
                    new AgentsModel()
                    {
                        id = idAgentC,
                        name = nameAgentC,
                        operations = operationAgentC
                    }
                };
        }
    }

}

