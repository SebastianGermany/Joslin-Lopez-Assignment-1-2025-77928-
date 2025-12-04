using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarApp.Models;

public abstract class RentalItem
{
    public string Manufacturer { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string BodyType { get; set; } = string.Empty;
    public string RegistrationNumber { get; set; } = string.Empty;

    public double Price { get; set; }
    public bool Borrowed { get; protected set; } = false;

    protected RentalItem(string manufacturer, string model, string bodyType,
                         string registrationNumber, double price)
    {
        if (string.IsNullOrWhiteSpace(manufacturer) ||
            string.IsNullOrWhiteSpace(model) ||
            string.IsNullOrWhiteSpace(bodyType) ||
            string.IsNullOrWhiteSpace(registrationNumber) ||
            price <= 0)
        {
            throw new ArgumentException("Invalid values provided for RentalItem.");
        }

        Manufacturer = manufacturer;
        Model = model;
        BodyType = bodyType;
        RegistrationNumber = registrationNumber;
        Price = price;
    }

    public abstract void Display();
}
