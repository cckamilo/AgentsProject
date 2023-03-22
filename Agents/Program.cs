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
//Interfaz de logica para agentes
IAgentsLogic iAgents;

try
{    
    iAgents = new AgentsLogic();
    //Seleccion de agentes
    var agents = iAgents.getAgents(data);
    if (agents)
    {
        //Seleccion de operaciones por agente
        var operations = iAgents.getOperations(data);
        if (operations.Any())
        {
            //Operacion de metódos por agentes
            //getMedia - getStaircase
            iAgents.postAgents(operations, factory);
        }
        else
        {
            Console.WriteLine("Datos incorrectos");
            Console.ReadLine();
        }
    }
    else
    {
        Console.WriteLine("Datos incorrectos");
        Console.ReadLine();
    }
   
}
catch (Exception ex)
{
    Console.WriteLine("Algo salio mal " + ex.Message);
    Console.ReadLine();
}





