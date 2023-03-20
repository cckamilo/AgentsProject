// See https://aka.ms/new-console-template for more information
using Agents;
using Agents.Logic;
using Agents.Logic.Interfaces;
using Agents.Models;

//Objeto que contine la configuracion de todos los agentes
AgentsSettingsModel data = new AgentsSettingsModel();
//Patron de diseño Factory Method
FactoryMethod factory;
factory = new FactoryAgents();
List<double> array = new List<double>();
int selectedAgent;
int selectedOperation;
try
{
    //Seleccion de agentes
    Console.WriteLine("Seleccione el número del agente:");
    for (int i = 0; i < data.agentsModel.Count; i++)
    {
        var count = (i + 1);
        Console.WriteLine(data.agentsModel[i].name + " --> " + count);
    }
    selectedAgent = Convert.ToInt32(Console.ReadLine());
    if (selectedAgent <= data.agentsModel.Count)
    {
        //Seleccion de operaciones por agente
        Console.WriteLine("Seleccione el número de la operacion:");
        var operations = data.agentsModel[selectedAgent - 1].operations;
        for (int i = 0; i < operations.Count; i++)
        {
            var count = (i + 1);
            Console.WriteLine(operations[i] + " --> " + count);
        }
        selectedOperation = Convert.ToInt32(Console.ReadLine());
        if (selectedOperation <= operations.Count)
        {

            if (selectedOperation > 1)
            {
                //Cantidad de registros a calcular
                Console.WriteLine("Tamaño de la escalera");
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
                Console.WriteLine("Cantidad de valores a calcular");
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
        else
        {
            Console.WriteLine("Datos incorrectos");
        }

    }
    else
    {
        Console.WriteLine("Datos incorrectos");
    }

}
catch (Exception ex)
{
    Console.WriteLine("Algo salio mal " + ex.Message);
}





