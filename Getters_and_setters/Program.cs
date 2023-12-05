using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Getters_and_setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Titanic", "Jim", "PG-13");
            Movie movie1 = new Movie("Unreleased", "Evans", "PG");

            Console.WriteLine(movie1.Rating);
            Console.ReadLine();


        }
    }
}
