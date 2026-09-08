namespace Training.OOP
{
    public class Car
    {
       public string Name { get; set; }
       public DateOnly Years { get; set; }
       public virtual void Start()
       {
            Console.WriteLine("Car is starting");
       }
    }
}
