using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentalCarApp.Models;

namespace RentalCarApp.Tests;

public class RentalCarUnitTests
{
    private RentalCar CreateDefaultCar() =>
        new RentalCar("Toyota", "Corolla", "Saloon", "T001", 50.0);

    [Fact]
    public void Constructor_SetsPropertiesCorrectly()
    {
        var car = CreateDefaultCar();

        Assert.Equal("Toyota", car.Manufacturer);
        Assert.Equal("Corolla", car.Model);
        Assert.Equal("Saloon", car.BodyType);
        Assert.Equal("T001", car.RegistrationNumber);
    }

    [Fact]
    public void Borrow_WhenNotBorrowed_SetsBorrowedTrue()
    {
        var car = CreateDefaultCar();

        bool result = car.Borrow();

        Assert.True(result);
        Assert.True(car.IsBorrowed());
    }

    [Fact]
    public void Borrow_WhenAlreadyBorrowed_ReturnsFalse()
    {
        var car = CreateDefaultCar();

        car.Borrow();
        bool result = car.Borrow();

        Assert.False(result);
    }

    [Fact]
    public void ReturnItem_SetsBorrowedToFalse()
    {
        var car = CreateDefaultCar();

        car.Borrow();
        car.ReturnItem();

        Assert.False(car.IsBorrowed());
    }

    [Fact]
    public void ChangePrice_UpdatesPrice()
    {
        var car = CreateDefaultCar();

        car.ChangePrice(80);

        Assert.Equal(80, car.Price);
    }

    [Fact]
    public void CheckPrice_ReturnsCorrectPrice()
    {
        var car = CreateDefaultCar();

        Assert.Equal(50.0, car.CheckPrice());
    }
}

