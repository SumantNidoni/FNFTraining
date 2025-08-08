using Assignments;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sumant_Assignments
{
    internal class Assignment5
    {
        public class MovieDB
        {
            public int id;
            public string name;
            public int year;
            public string language;
             public double earnings;

            public MovieDB(int id, string name, int year, string language, double earnings)
            {
                this.id = id;
                this.name = name;
                this.year = year;
                this.language = language;
                this.earnings = earnings;
            }
        }

        public static List<MovieDB> movies = new List<MovieDB>();
        static void Main(string[] args)
        {
            //Create a CRUD based App for developing a Movie Database software where the user can add, remove and update movies of his Video library.It should be a menu driven program that has 4 use cases for add, removing, finding and updating movie info in the application.


            Menu();

            
        }

        public static void Menu()
        {
            do
            {
                Console.WriteLine("=======================Movie Menu====================");
                Console.WriteLine("1-Add   2-Remove  3-Update  4-Find  5-Display");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addMovie();
                        break;

                    case 2:
                        removeMovie();
                        break;

                    case 3:
                        updateMovie();
                        break;

                    case 4:
                        findMovie();
                        break;

                    case 5:
                        displayAll();
                        break;

                    default:
                        Console.WriteLine("Invalid Option..Please Choose a correct option from the menu!!");
                        break;
                }
            }while(true);


            
        }

        private static void updateMovie()
        {
            Console.WriteLine("Enter the id of the movie to update");
            int id = int.Parse(Console.ReadLine());
            MovieDB movie = movies.Find(m => m.id == id);
            if(movie != null)
            {
                Console.WriteLine("Enter the updated name");
                movie.name = Console.ReadLine();
                Console.WriteLine("Enter the updated year");
                movie.year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the updated language");
                movie.language = Console.ReadLine();
                Console.WriteLine("Enter the updated earnings");
                movie.earnings = double.Parse(Console.ReadLine());

            }else
            {
                Console.WriteLine("Please Enter corect movie ID!!");
            }


        }

        private static void displayAll()
        {
            foreach (MovieDB movie in movies)
            {
                Console.WriteLine($"{movie.id}  {movie.name}  {movie.year}  {movie.language}  {movie.earnings}");
            }
        }

        private static void findMovie()
        {
            Console.WriteLine("Enter the id to ne found");
            int id = int.Parse(Console.ReadLine()) ;
            MovieDB movie = movies.Find(m => m.id == id);
            if (movie != null)
            {
                Console.WriteLine($"{movie.id}  {movie.name}  {movie.year}  {movie.language}  {movie.earnings}");
            } else
            {
                Console.WriteLine("Movie not found with ID");
            }
        }

        private static void removeMovie()
        {
            Console.WriteLine("Enter the id of the movie to be deleted:");
            int id = int.Parse(Console.ReadLine());
            MovieDB movieId = movies.Find(m => m.id == id);
            if(movieId != null)
            {
                movies.Remove(movieId);
                Console.WriteLine("Movie deleted succesfully!!");
            } else
            {
                Console.WriteLine("Wrong movie ID..Please Retry!!!");
            }
        }

        private static void addMovie()
        {
            Console.WriteLine("Enter the id of the movie:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the movie name:");
            string name= Console.ReadLine();
            Console.WriteLine("Enter the year it released");
            int yr = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the language of the movie");
            string lang = Console.ReadLine();
            Console.WriteLine("Enter the total earning of the movie");
            double earnings = double.Parse(Console.ReadLine());
            movies.Add(new MovieDB(id, name, yr, lang, earnings));
        }
    }
}
