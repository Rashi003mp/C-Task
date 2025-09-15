using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    internal class prgrm
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
            new Person { Name = "Alice", Age = 30, City = "New York" },
                new Person { Name = "Bob", Age = 22, City = "Chicago" },
                new Person { Name = "Charlie", Age = 28, City = "New York" },
                new Person { Name = "Diana", Age = 35, City = "Los Angeles" },
                new Person { Name = "Ethan", Age = 40, City = "New York" }

            };

            var result = from p in people
                         where p.Age > 25 && p.City == "New York"
                         select new { p.Name, p.Age };
            foreach (var person in result)
            {
                Console.WriteLine($"Name: {person.Name},Age: {person.Age}");
            }


        }
    }


}
