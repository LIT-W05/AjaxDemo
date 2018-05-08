using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person
            //{
            //    FirstName = "Avrumi",
            //    LastName = "Friedman",
            //    Age = 36
            //};
            //List<Car> cars = new List<Car>();
            //cars.Add(new Car { Make = "Lamborghini" });
            //cars.Add(new Car { Make = "Ferarri" });
            //p.Cars = cars;

            //string json = JsonConvert.SerializeObject(p, Formatting.Indented);
            //Console.WriteLine(json);
            //File.WriteAllText("output.json", json);
            //string json = File.ReadAllText("output.json");
            //Person p = JsonConvert.DeserializeObject<Person>(json);
            //Console.WriteLine(p.FirstName);
            Console.ReadKey(true);
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }

    public class Car
    {
        public string Make { get; set; }
    }
}
