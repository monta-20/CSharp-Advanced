using System;
using Training;
using Training.OOP;

namespace Monta; 

class Program
{
    static void Main(string[] args)
    {
        Car mercedes = new Mercedes
        {
            Name = "Mercedes-Benz",
            Years = DateOnly.FromDateTime(new DateTime(2023, 1, 1)),
        };
        Car volkswagen = new Volksawgen
        {
            Name = "Volkswagen",
            Years = DateOnly.FromDateTime(new DateTime(2023, 1, 2)),
        };
        mercedes.Start();
        volkswagen.Start();
    }
}
