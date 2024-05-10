using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingSystem.Models
{
    public class Menu
    {
        public static void MenuSystem()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("Seja bem-vindo ao nosso sistema de estacionameto!!");
            Console.WriteLine("===================================================");
            Console.WriteLine("1) Cadastre o seu veiculo.");
            Console.WriteLine("2) Pagar taxa de estacionamento.");
            Console.WriteLine("3) Listar veiculo.");
            Console.WriteLine("4) Remover veiculo.");
            Console.WriteLine("0) Encerrar.");
            Console.WriteLine("===================================================");
            Console.Write("Digite uma opção: ");
        }

        public static void AnyKey()
        {
            Console.WriteLine("===================================================");
            Console.Write("Digite qualquer tecla para voltar:");
            Console.ReadKey();
            Console.Clear();
        }

        // public static void ParkingPay() 
        // {
        //     Console.WriteLine("===================================================");
        //     Console.Write("Digite a placa do carro: ");
        // }
    }
}