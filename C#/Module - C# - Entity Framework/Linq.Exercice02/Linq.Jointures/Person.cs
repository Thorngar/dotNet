using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Jointures
{
    using System.Collections.Generic;

    public class PersonWithCity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public int Age { get; set; }
        public string CityName { get; set; }
        public int CityZipCode { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public int Age { get; set; }
        public City City { get; set; }
    }

    public class City
    {
        public string Name { get; set; }
        public int ZipCode { get; set; }
        public int PersonId { get; set; }
    }

    public class Mockup
    {
        private static readonly int[] numbers = new[] { 1, 5, -6, 0, -15, -1, 3, 5, 18, 5, 2, -4, 7, 6, 5 };
        private static readonly Person[] persons = new[]
        {
            new Person { Id = 1, Firstname = "Cédric", Age = 39 },
            new Person { Id = 2, Firstname = "Ana", Age = 37 },
            new Person { Id = 3, Firstname = "Mathieu", Age = 6 },
            new Person { Id = 4, Firstname = "Denis", Age = 39 },
            new Person { Id = 5, Firstname = "Céline", Age = 27 },
        };
        private static readonly City[] cities = new[]
        {
            new City { Name = "Hornu", ZipCode = 7301, PersonId = 1 },
            new City { Name = "Tournai", ZipCode = 7500, PersonId = 3 },
            new City { Name = "Mons", ZipCode = 7000, PersonId = 5 },
            new City { Name = "Hornu", ZipCode = 7301, PersonId = 2 },
            new City { Name = "Hornu", ZipCode = 7301, PersonId = 4 },
        };

        public static IEnumerable<int> GetAllNumber() => numbers;

        public static IEnumerable<Person> GetAllPerson() => persons;

        public static IEnumerable<City> GetAllCity() => cities;
    }
}
