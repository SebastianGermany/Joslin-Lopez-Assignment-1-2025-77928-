using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalCarApp.Models;

namespace RentalCarApp.ConsoleApp;

public static class RentalCarDriver
{
    public static void Run()
    {
        var car1 = new RentalCar("Toyota", "Corolla", "Saloon", "T123", 50.0, false);
        var car2 = new RentalCar("Honda", "Civic", "HatchBack", "H987", 55.0);
        var car3 = new RentalCar("BMW", "Z4", "Convertible");
        var car4 = new RentalCar("Nissan", "Qashqai", "CrossOver", "N444", 65.0);

        car1.Display();
        car1.Borrow();
        car1.Display();
        car1.ReturnItem();

        car2.Display();
        car2.ChangePrice(70.0);

        car3.Display();

        car4.Borrow();
        car4.Borrow(); // triggers error
    }
}

