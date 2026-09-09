using System;
using Training;
using Training.OOP;

namespace Monta; 

class Program
{

    static void Main(string[] args)
    {
        /* DateTime */
        DateTime t1 = new DateTime(2026, 6, 20);
        DateTime t2 = new DateTime(2026, 5, 20);
        TimeSpan t3 = t1 - t2;
        Console.WriteLine($"Hello, World! {t3}");
        /* TimeSpan */
        TimeSpan ts1 = new TimeSpan(2, 30, 0);
        TimeSpan ts2 = TimeSpan.FromHours(1.5); // FromDays , FromHours, FromMinutes, FromSeconds, FromMilliseconds
        Console.WriteLine($"Hello, World! {ts2}");
        /* DateTimeKind */
        // DateTime has property Kind which can be Local, Utc or Unspecified
        Console.WriteLine($"Kind type is {t2.Kind}"); // unspecified 
        /* DateTimeOffset */
        // DateTimeOffset is add Offset to DateTime, it is used to represent a point in time relative to UTC
        DateTimeOffset dtoffset = DateTimeOffset.Now;
        Console.WriteLine($"Hello, World! {dtoffset}");
        /* DateOnly */
        DateOnly donly = new DateOnly(2026, 6, 20);
        Console.WriteLine($"Hello, World! {donly}");
        /* TimeOnly */
        TimeOnly tonly = new TimeOnly(9, 0);
        Console.WriteLine($"Hello, World! {tonly}");
        /* DateOnly and TimeOnly can be combined to create DateTime */
        DateOnly date = new DateOnly(2026, 9, 9);
        TimeOnly time = new TimeOnly(14, 30);
        DateTime dateTime = date.ToDateTime(time);
        /* TimeZoneInfo */
        // The exact time-zone IDs depend on the operating system, so don't blindly assume Windows IDs will work everywhere.
        TimeZoneInfo zone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        DateTime local = TimeZoneInfo.ConvertTimeFromUtc(t1, zone);
        /* Formatting Dates */
        Console.WriteLine(date.ToString("dd/MM/yyyy")); // date.ToString("yyyy-MM-dd HH:mm:ss")
        /* Parsing date from string */
        string input = "2026-09-24";
        if (DateTime.TryParse(input, out DateTime parsedDate))
        {
            Console.WriteLine($"Parsed date: {parsedDate}");
        }
        else
        {
            Console.WriteLine("Invalid date format.");

        }
    }
}
