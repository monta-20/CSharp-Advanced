using System;
using Training;
using Training.OOP;

namespace Monta; 

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>
        {
            new Mercedes { Name = "Mercedes A-Class", Years = new DateOnly(2020, 1, 1) },
            new Volksawgen { Name = "Volksawgen Golf", Years = new DateOnly(2019, 1, 1) },
            new Mercedes { Name = "Mercedes C-Class", Years = new DateOnly(2021, 1, 1) },
            new Volksawgen { Name = "Volksawgen Passat", Years = new DateOnly(2018, 1, 1) }
        };
        cars.Sort();
    }
}
