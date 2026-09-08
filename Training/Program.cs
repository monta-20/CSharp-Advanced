using System;
using Training;
using Training.OOP;

namespace Monta; 

class Program
{
    static void Main(string[] args)
    {
        Mercedes mercedes = new Mercedes
        {
            Name = "Mercedes-Benz",
            Years = DateOnly.FromDateTime(new DateTime(2023, 1, 1)),
        };
        mercedes.Start();
    }
}
