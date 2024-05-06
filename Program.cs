using ParkingSystem.Models;
using ParkingSystem.Services;

Parking parkingSystem = new();
Menu menu = new();
int option;

do
{
    Console.Clear();
    menu.MenuSystem();
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Clear();
            parkingSystem.AddVehicles();
            menu.AnyKey();
            break;

        case 3:
            Console.Clear();
            parkingSystem.ListVehicles();
            menu.AnyKey();
            break;

        case 4:
            Console.Clear();
            parkingSystem.RemoveVehicles();
            menu.AnyKey();
            break;


        default:
            break;
    }

} while (option != 0);
