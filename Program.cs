using ParkingSystem.Models;
using ParkingSystem.Services;

Parking parkingSystem = new();
int option;

do
{
    Console.Clear();
    Menu.MenuSystem();
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Clear();
            parkingSystem.AddVehicles();
            Menu.AnyKey();
            break;

        case 2:
        Console.Clear();
        parkingSystem.Payment();
        Menu.AnyKey();
        break;

        case 3:
            Console.Clear();
            parkingSystem.ListVehicles();
            Menu.AnyKey();
            break;

        case 4:
            Console.Clear();
            parkingSystem.RemoveVehicles();
            Menu.AnyKey();
            break;


        default:
            break;
    }

} while (option != 0);
