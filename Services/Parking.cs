using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkingSystem.Models;

namespace ParkingSystem.Services
{
    public class Parking
    {
        public string Placa { get; set; }
        List<string> vehicles = new List<string>();

        public void AddVehicles() 
        {
            System.Console.Write("Adicionar a placa: ");
            Placa = Console.ReadLine(); 
            vehicles.Add(Placa.ToUpper());
            Console.Clear();
            System.Console.WriteLine("Veiculo adiconando com sucesso!!");
        }

        public void ListVehicles()
        {
            int index = 1;
            System.Console.WriteLine("Todos os veiculos no estacionamento:");
            Console.WriteLine("===================================================");

            // DateTime horaDeCadastro = DateTime.Now;
            foreach (string vehiclesNumber in vehicles)
            {
                System.Console.WriteLine($"{index} - {vehiclesNumber}");
                index++;
            }
        }

        public void RemoveVehicles() 
        {
            System.Console.Write("Remover veiculo pela placa: ");
            Placa = Console.ReadLine();
            vehicles.Remove(Placa.ToUpper());
            Console.Clear();
            System.Console.WriteLine("Veiculo removido com sucesso!!");
        }
    }
}