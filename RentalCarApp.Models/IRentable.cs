    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarApp.Models;

public interface IRentable
{
    bool Borrow();
    void ReturnItem();
    bool IsBorrowed();
    double CheckPrice();
    void ChangePrice(double newPrice);
    void Display();
}
