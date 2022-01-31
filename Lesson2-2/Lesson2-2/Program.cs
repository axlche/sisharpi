using System;

namespace Lesson2Fin
{
    //3 (array and loops) add array of string values. Output values which length is 4
    /*internal class Program
    {
        static void Main(string[] args)
        {
            string[] Cities = { "Warszawa", "Wroclaw", "Katowice", "sop", "Gdansk", "Bygdoscz" };
            string[] find = Array.FindAll(Cities,
                                     element => element.Length >= 8);
            Console.WriteLine(find);

        }

    }*/
    //1 (Overloading) create 3 methods that calculate area of a circle and a square
    internal class Program2
    {
        static int Aresa(int x)
        {
            int sqr = x * x;
            return sqr;
        }
        static double Aresa(double y)
        {
            double rad = Math.PI * y * y;
            return rad;
        }
        static float Aresa(float p)
        {
            float lol = p + p;
            return lol;
        }
        static void Main(string[] args)
        {
            int area1 = Aresa(10);
            double area2 = Aresa(6);
            float area3 = Aresa(15);
            Console.WriteLine($"Area of the square is {area1}");
            Console.WriteLine($"Area of the circle is {area2}");
            Console.WriteLine($"Float. Your sum is {area3}");

        }

    }
}