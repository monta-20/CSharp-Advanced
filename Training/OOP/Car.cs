namespace Training.OOP
{
    public class Car :IComparable<Car>
    {
       public string Name { get; set; }
       public DateOnly Years { get; set; }
        
       public int CompareTo(Car? other)
       {
           if (other == null) return 1;
           return Years.CompareTo(other.Years);
       }
    }
}
