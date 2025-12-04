using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarApp.Models;

public class RentalCar : RentalItem, IRentable
{
    // MAIN constructor (full)
    public RentalCar(string manufacturer, string model, string bodyType,
                     string registrationNumber, double price, bool borrowed)
        : base(manufacturer, model, bodyType, registrationNumber, price)
    {
        Borrowed = borrowed;
    }

    // Constructor #2 (no borrowed parameter - default false)
    public RentalCar(string manufacturer, string model, string bodyType,
                     string registrationNumber, double price)
        : base(manufacturer, model, bodyType, registrationNumber, price)
    {
        Borrowed = false;
    }

    // Constructor #3 (only basic info)
    public RentalCar(string manufacturer, string model, string bodyType)
        : base(manufacturer, model, bodyType, "UNKNOWN", 1)
    {
        Borrowed = false;
    }


    // -------- METHODS ----------
    public bool Borrow()
    {
        if (!Borrowed)
        {
            Borrowed = true;
            Console.WriteLine($"Car {Manufacturer} {Model} is now borrowed.");
            return true;
        }

        Console.WriteLine($"Error: Car {Manufacturer} {Model} is already borrowed.");
        return false;
    }

    public void ReturnItem()
    {
        Borrowed = false;
        Console.WriteLine($"Car {Manufacturer} {Model} has been returned.");
    }

    public bool IsBorrowed() => Borrowed;

    public double CheckPrice() => Price;

    public void ChangePrice(double newPrice)
    {
        if (newPrice > 0)
        {
            Price = newPrice;
            Console.WriteLine($"New price set: €{Price}");
        }
        else
        {
            Console.WriteLine("Invalid price. Must be > 0.");
        }
    }

    public override void Display()
    {
        Console.WriteLine(new string('*', 40));
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Body Type: {BodyType}");
        Console.WriteLine($"Registration Number: {RegistrationNumber}");
        Console.WriteLine($"Price: €{Price}");
        Console.WriteLine($"Borrowed: {Borrowed}");
        Console.WriteLine(new string('*', 40));
        Console.WriteLine();
    }
}
