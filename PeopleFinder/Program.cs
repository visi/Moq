using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PeopleFinder {
    class Program {
        static void Main(string[] args) {
            var repository = new PersonRepository();

            var people = new People(repository);

            var persons = people.Query(p => p.FirstName == "John");

            foreach (var person in persons) {
                Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
            }

            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
