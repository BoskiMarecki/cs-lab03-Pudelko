using PudelkoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PudelkoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Pudełko toString: ");
            Console.WriteLine(new Pudelko(2.5, 9.321, 0.1, UnitOfMeasure.meter).ToString);
            Console.WriteLine(new Pudelko(2.5, 9.321, 0.1, UnitOfMeasure.meter).ToString("m"));
            Console.WriteLine(new Pudelko(2.5, 9.321, 0.1, UnitOfMeasure.meter).ToString("cm"));
            Console.WriteLine(new Pudelko(2.5, 9.321, 0.1, UnitOfMeasure.meter).ToString("mm"));

            Console.WriteLine("\n Objetosc: ");
            Console.WriteLine(new Pudelko(1, 1, 1, UnitOfMeasure.meter).ToString);
            Console.WriteLine(new Pudelko(1, 1, 1, UnitOfMeasure.meter).ToString("m"));
            Console.WriteLine(new Pudelko(1, 1, 1, UnitOfMeasure.meter).ToString("cm"));

            Console.WriteLine("\n Pole: ");
            Console.WriteLine(new Pudelko(2.5, 9.321, 0.1, UnitOfMeasure.meter).ToString);
            Console.WriteLine(new Pudelko(2.5, 9.321, 0.1, UnitOfMeasure.meter).ToString("m"));
            Console.WriteLine(new Pudelko(2.5, 9.321, 0.1, UnitOfMeasure.meter).ToString("cm"));
            Console.WriteLine(new Pudelko(2.5, 9.321, 0.1, UnitOfMeasure.meter).ToString("mm"));

        }

        /*private static int ComparePudelka(Pudelko p1, Pudelko p2)
        {
            
        }*/


    }
}
