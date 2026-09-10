using Training.Models;

namespace Monta;

class Program
{
    static void Main(string[] args)
    {
        Person p = new Person("John",10);
        List<Person> list = new List<Person>();
        list = p.fillData();
        //var result = list.GroupBy(x => new
        //{
        //   x.Name,
        //   x.Age
        //}); 
        //foreach ( var group in result)
        //{ 
        //    Console.WriteLine($"Name: {group.Key}");
        //    foreach (var person in group)
        //    {
        //        Console.WriteLine($"  Age: {person.Age}");
        //    }
        //}
        var output = list.Select(x => x); 
       // var output = list;
        foreach ( var item in output)
        {
            Console.WriteLine($"Item is {item}");
        }
    }
}
