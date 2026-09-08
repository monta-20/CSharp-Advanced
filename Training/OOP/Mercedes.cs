namespace Training.OOP
{
    public class Mercedes : Car
    {
        public Mercedes() : base() { }
        public override void Start()
        {
            Console.WriteLine("Mercedes is starting");
        }
    }
}
