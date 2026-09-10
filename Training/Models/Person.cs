namespace Training.Models
{
    internal class Person
    {
        public string? Name { get; set; }
        public byte Age { get; set; }
        public Person (string? Name , byte Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public List<Person> fillData()
        {
            List<Person> p = new List<Person>
            {
                new Person(Name = "Jane", Age = 10 ),
                new Person(Name = "Jane", Age = 10 ),
                new Person(Name = "Bob", Age = 40 )
            };
            return p;
        }
    }
}
