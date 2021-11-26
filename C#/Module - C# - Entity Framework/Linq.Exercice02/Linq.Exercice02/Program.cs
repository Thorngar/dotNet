using System;

namespace Linq.Exercice02
{

    using System.Collections.Generic;
    using System.Linq;
    using Linq.Exercice02;

    class Program
    {
        static void DisplayInConsole(IEnumerable<Car> cars)
        {
            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Id} - {car.Color} - {car.CreationDate} - {car.Manufacturer} - {car.Speed}");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var cars = CarMockup.GetAll();

            // récupération des voitures rouge

            var a = cars.Where(cars => cars.Color == ColorType.Red);

            DisplayInConsole(a);

            // récupération des voitures rouges ou jaune

            var b = cars.Where(cars => cars.Color == ColorType.Red || cars.Color == ColorType.Yellow);

            DisplayInConsole(b);

            // tri des différentes voitures selon leur ID de manière croissante

            var c = cars.OrderBy(cars => cars.Id);

            DisplayInConsole(c);

            // tri des différentes voitures selon leur puissance de manière décroissante ainsi que sur leur marque

            var d = cars.OrderByDescending(cars => cars.Speed).ThenByDescending(cars => cars.Manufacturer);

            DisplayInConsole(d);

            // récupération des voitures ayant une couleur Jaune ainsi qu'une vitesse supérieur à 150

            var e = cars.Where(cars => cars.Color == ColorType.Yellow && cars.Speed > 150);

            DisplayInConsole(e);

            // récupération de la dernière voiture ayant la couleur rouge

            var f = cars.Where(cars => cars.Color == ColorType.Red).TakeLast(1);
            var f2 = cars.LastOrDefault(cars => cars.Color == ColorType.Red);

            DisplayInConsole(f);

            // la première voiture jaune

            var t = cars.FirstOrDefault(cars => cars.Color == ColorType.Yellow);
            
            Console.WriteLine("{0,5} {1,15} {2,10}{3,5}{4,10}", t.Id, t.Manufacturer, t.Color, t.Speed, t.CreationDate.ToString("dd/MM/yyyy"));

            // récupération de la puissance moyenne de toutes les voitures

            var g = cars.Average(cars => cars.Speed);

            Console.WriteLine(g);
            Console.WriteLine();

            // récupération de la puissance de la voiture ayant une couleur Bleu ainsi que la marque "Megane"

            var h = cars.SingleOrDefault(cars => 
                    cars.Color == ColorType.Blue &&
                    cars.Manufacturer.Equals("megane", StringComparison.InvariantCultureIgnoreCase));

            // récupération des informations suivantes : Id, Couleur en string, Puissance dans un tableau

            // mapping de Car vers un autre objet de tpye CarDetail
            var i = cars.Select(cars = new CarDetail
            {
                Id = cars.Id,
                ColorType = cars.Color.ToString(),
                Speed = cars.Speed,
            });


            // y a-t-il au moins une voiture ayant une couleur Grise ?

            // cars.Exists(cars => car.Color == ColorType.Gray);

            if (cars.Any(cars => cars.Color == ColorType.Gray))
            {
                Console.WriteLine("Oui");
            }
            else
            {
                Console.WriteLine("Non");
            }

            // toutes les voitures sont-elles Blanche ?

            if (cars.All(cars => cars.Color == ColorType.White))
            {
                Console.WriteLine("Oui");
            }
            else
            {
                Console.WriteLine("Non");
            }
            // récupération des voitures ayant moins de 5 ans

            var dateLimit = DateTime.UtcNow.AddYears(-5);
            var k = cars.Where(cars => cars.CreationDate < dateLimit);
            DisplayInConsole(k);

            // moins performant car le calcul de la date sera fait pour chaque élément
            var n = cars.Where(cars => cars.CreationDate < DateTime.UtcNow.AddYears(-5));

            // récupération de toutes les voitures sous la forme d'un tableau

            var l = cars.ToArray();
            DisplayInConsole(l);

            // mettre un .ToList() pour la mémoire pour éviter qu'à chaque instruction il parcoure les listes par rapport au .Where() surtout

            var listePasEncoreCalculee = cars.Where(cars => cars.Speed > 50);
            // var listePasEncoreCalculee = cars.Where(cars => cars.Speed > 50).ToList();

            var listeToujoursPasCalculee = listePasEncoreCalculee.Where(cars => cars.Color == ColorType.Red);
            var listeToujoursPasCalculee2 = listePasEncoreCalculee.Where(cars => cars.Color == ColorType.Yellow);

            var listeAvecResultat = listeToujoursPasCalculee.ToList();
            var listeAvecResultat2 = listeToujoursPasCalculee2.ToList();

            Console.ReadLine();
        }
    }
}
