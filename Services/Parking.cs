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
        public string Registro { get; set; }
        List<string> Vehicles = new List<string>();

        public void AddVehicles() 
        {
            DateTime horaDeCadastro = DateTime.Now;

            System.Console.Write("Digite a placa do veiculo: ");
            Placa = Console.ReadLine(); 
            Registro = $"{Placa.ToUpper()}: Cadastrado em: {horaDeCadastro}";
            Vehicles.Add(Registro);
            Console.Clear();
            System.Console.WriteLine($"Veiculo {Placa.ToUpper()} adicionado com sucesso às {horaDeCadastro}!!");
        }

        public void ListVehicles()
        {
            int index = 1;
            System.Console.WriteLine("Todos os veiculos no estacionamento:");
            Console.WriteLine("===================================================");


            foreach (string VehiclesNumber in Vehicles)
            {
                Console.WriteLine($"{index} - {VehiclesNumber}");
                index++;
            }
        }

        public void RemoveVehicles() 
        {
            Console.Write("Remover veiculo pela placa: ");
            Placa = Console.ReadLine();
            Vehicles.Remove(Registro);
            Console.Clear();
            Console.WriteLine("Veiculo removido com sucesso!!");
        }
    }
}