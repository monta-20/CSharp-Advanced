using System;
using Training;

namespace Monta; 

class Program
{
    static void Main(string[] args)
    {   //First Use
        int percentage = -10;
        if (percentage.IsBetween(0, 100))
            Console.WriteLine("Percentage is valid");
        else
            Console.WriteLine("Invalid percentage");
        //Second Use
        var user = new User
        {
            FirstName = "Montassar",
            LastName = "Ben Brahim"
        };

        string fullName = user.GetFullName();
        Console.WriteLine(fullName);

    }
}
