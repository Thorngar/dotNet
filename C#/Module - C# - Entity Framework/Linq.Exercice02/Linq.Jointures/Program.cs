using System;

namespace Linq.Jointures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Mockup.GetAllNumber();
            var persons = Mockup.GetAllPerson();
            var cities = Mockup.GetAllCity();

            DisplayNumbers(numbers);

            var numberGreaterThan5 = from number in numbers where number > 5 select number;
            DisplayNumbers(numberGreaterThan5);

            DisplayPersons(persons);

            var personAge39 = from person in persons where person.Age == 39 select person;
            DisplayPersons(personAge39);

            // les personnes affichées par ordre d'age

            var personsByAge = persons.OrderBy(persons => persons.Age);

            // liste de personnes avec la ville

            var personsCities = (from City in cities
                                 join person in persons on City.PersonId equals person.Id
                                 select new Person
                                 {
                                     Age = person.Age,
                                     Firstname = person.Firstname,
                                     Id = person.Id,
                                     City = new City
                                     {
                                         Name = City.Name,
                                         ZipCode = City.ZipCode,
                                     }
                                 }).ToList();
            /* OU 
            select new PersonWithCity
            {
                Age = person.Age,
                Firstname = person.Firstname,
                Id = person.Id,
                CityName = City.Name,
                CityZipCode = City.ZipCode,
            }).ToList(); 
            */

            var personsCitiesExtension = cities.Join(
                                         persons,
                                         city => city.PersonId, // ce sont des clés ici, ça aurait pu être cityEntity ou personsEntity
                                         persons => persons.Id,
                                         (c, p) => new Person // c et un alias vers City et p vers Person
                                         {
                                             Id = p.Id,
                                             Age = p.Age,
                                             Firstname = p.Firstname,
                                             City = new City()
                                             {
                                                 Name = c.Name,
                                                 ZipCode = c.ZipCode,
                                             },
                                         }).ToList();



            // les personnes qui habitent "Hornu"

            var personsHornu = persons.Where(persons => persons.City.Name == "Hornu");

            // les personnes qui habitent "Bruxelles"


            // les personnes avec les informations de la ville
        }

        static void DisplayNumbers(IEnumerable<int> numbers)
        {
            Console.WriteLine("Nombres: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
        }

        static void DisplayPersons(IEnumerable<Person> persons)
        {
            Console.WriteLine("Personnes: ");
            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Firstname} {person.Age}");
            }

            Console.WriteLine();
        }
    }
}
