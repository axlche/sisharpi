using System;

namespace Lesson1
{
    //2. (constructor) Create class with 2 constructors and create 2 objects that initialize 2 ways
    //internal class Program
    class Movie
    {
        public string genre;
        public string year;
        public Movie()
        {
            genre = "Horror";
            year =  ""
        }
        static void Main(string[] args)
        {
            Movie Midsommar = new Movie();
            Console.WriteLine(Midsommar.genre);
        }
    }
}
