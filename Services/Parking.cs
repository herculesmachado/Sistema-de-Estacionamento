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
        public DateTime horaDeCadastro = DateTime.Now;
        List<string> Vehicles = new List<string>();

        public void AddVehicles() 
        {
            Console.Write("Digite a placa do veiculo: ");
            Placa = Console.ReadLine().ToUpper(); 
            Registro = $"{Placa}: Cadastrado em: {horaDeCadastro}";
            Vehicles.Add(Registro);
            Console.Clear();
            Console.WriteLine($"Veiculo {Placa} adicionado com sucesso em {horaDeCadastro}!!");
        }

        public void Payment()
        {
            decimal defaultValue = 5;
            
            Console.Write("Digite a placa do carro para efetuar o pagamento: ");
            Placa = Console.ReadLine().ToUpper();

            Console.Write("Digite o total de horas no estacionamento: ");
            decimal horas = decimal.Parse(Console.ReadLine());

            decimal total = defaultValue * horas;

            Console.Clear();

            Console.WriteLine("===================================================");
            Console.WriteLine($"{Placa}: O pagamento é de {total} reais");

        }



        public void ListVehicles()
        {
            int index = 1;
            Console.WriteLine("Todos os veiculos no estacionamento:");
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
            Console.Clear();

            if (Placa == Registro)
            {   
                Console.WriteLine("Veiculo removido com sucesso!!");
                Vehicles.Remove(Registro);
            } 
            else 
            {
                System.Console.WriteLine("Testo failed");
            }
        }
    }
}