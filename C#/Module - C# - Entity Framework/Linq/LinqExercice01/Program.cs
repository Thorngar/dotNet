
namespace LinqExercice01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>();

            FillMovies(movies);           

            // les films sortis avant 2000

            var before2000 = movies.Where(movies => movies.Year < 2000).ToList();

            DisplayMovies(before2000);

            // les films qui contiennent le caractère 'i'

            var containI = movies.Where(movies => movies.Name.Contains('i')).ToList();

            DisplayMovies(containI);

            // les films après 2000 affiché par ordre croissant de l'année de sortie

            var after2000 = movies.Where(movies => movies.Year > 2000).OrderBy(movies => movies).ToList();

            DisplayMovies(after2000);

            // compter le nombre de films des années 80
            var count80 = movies.Count(movies => (movies.Year >= 1980) && (movies.Year < 1990));

            Console.WriteLine("Nombre de films {0}", count80);

            // la liste des deux premiers films

            var twoFirst = movies.Take(2).ToList();

            // la liste des noms de mes films

            var allMovies = movies.Select(movies => movies.Name);

            Console.ReadLine();
        }

        static void FillMovies(List<Movie> movies)
        {
            movies.Add(new Movie
            {
                Id = 1,
                Name = "Matrix",
                Year = 2000,
            });

            movies.Add(new Movie
            {
                Id = 2,
                Name = "Die Hard",
                Year = 1989,
            });

            movies.Add(new Movie
            {
                Id = 6,
                Name = "Scarface",
                Year = 1984,
            });
            movies.Add(new Movie
            {
                Id = 7,
                Name = "La communauté de l'anneau",
                Year = 2001,
            });
        }

        static void DisplayMovies(List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Id} {movie.Name} {movie.Year}");
            }

            Console.WriteLine();
        }
    }
}