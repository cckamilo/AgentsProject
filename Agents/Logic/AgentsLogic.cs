using System;
using Agents.Logic.Interfaces;
using Agents.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Agents.Logic
{
    public class AgentsLogic : IAgentsLogic
    {
        bool error;
        int selectedAgent;
        int selectedOperation;
        public bool getAgents(AgentsSettingsModel data)
        {
            Console.WriteLine("Seleccione el número del agente:");
            Console.WriteLine("");
            for (int i = 0; i < data.agentsModel.Count; i++)
            {
                var count = (i + 1);
                Console.WriteLine(data.agentsModel[i].name + " --> " + count);
            }
            selectedAgent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            if (selectedAgent > data.agentsModel.Count)
            {
                return error;
            }
            return true;
        }

        public List<string> getOperations(AgentsSettingsModel data)
        {

            List<string> operations = new List<string>();
            Console.WriteLine("Seleccione el número de la operacion:");
            Console.WriteLine("");
            operations = data.agentsModel[selectedAgent - 1].operations;
            for (int i = 0; i < operations.Count; i++)
            {
                var count = (i + 1);
                Console.WriteLine(operations[i] + " --> " + count);
            }
            selectedOperation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            if (selectedOperation > operations.Count)
            {
                return operations = new List<string>();
            }
            return operations;
        }

        public void postAgents(List<string> operations, FactoryMethod factory)
        {
            List<double> array = new List<double>();

            if (selectedOperation > 1)
            {
                //Cantidad de registros a calcular
              
                Console.WriteLine("Tamaño de la escalera: ");
                Console.WriteLine("");
                var value = Convert.ToInt32(Console.ReadLine());
                if (value > 0 && value < 100)
                {
                    //Ejecucion de configuracion por agente
                    factory.getStaircase(selectedAgent, value);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Datos incorrectos");
                    Console.ReadLine();
                }
            }
            else
            {
                //Cantidad de registros a calcular
                Console.WriteLine("Cantidad de valores a calcular: ");
                int values = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= Convert.ToInt32(values); i++)
                {
                    Console.WriteLine($"Ingrese el #{i}");
                    var item = Convert.ToDouble(Console.ReadLine());
                    array.Add(item);
                }
                //Ejecucion de configuracion por agente
                factory.getMedia(selectedAgent, array.ToArray());
                Console.ReadLine();

            }

        }
    }
}

