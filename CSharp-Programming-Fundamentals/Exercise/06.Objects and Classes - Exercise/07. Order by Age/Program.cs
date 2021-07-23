using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Person> persons = new List<Person>();
            while ((input = Console.ReadLine())!="End")
            {
                List<string> currentPerson= input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                Person person = new Person(currentPerson[0], currentPerson[1], int.Parse(currentPerson[2]));
                persons.Add(person);
            }
            Console.WriteLine(string.Join(Environment.NewLine,persons.OrderBy(x=>x.Age)));
        }
        class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
            public Person(string name, string id, int age)
            {
                this.Name = name;
                this.ID = id;
                this.Age = age;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"{Name} with ID: {ID} is {Age} years old."); 
                return sb.ToString();
            }
        }
    }
}
