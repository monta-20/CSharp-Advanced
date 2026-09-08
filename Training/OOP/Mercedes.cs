namespace Training.OOP
{
    public class Mercedes : Car
    {
        public Mercedes() : base() { }
        public void Model()
        {
            Console.WriteLine($"Mercedes model: {Name} in year {Years}");
        }
    }
}
