using System;

namespace uppgift_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange antal dagar och antal km");
            Console.WriteLine("skriv ett tal till dagar och km");
            int dag= int.Parse(Console.ReadLine());
            int antalkm = int.Parse(Console.ReadLine());
            Console.WriteLine("Startupgift: 300 kr ");
            Console.WriteLine("Kostnad 1 kr per km:" + antalkm);
            Console.WriteLine("Kostnad per dag förutom den första dagen: 500 kr: " + (dag-1) + "dagar");
            int total = 300 + antalkm + 500 * (dag - 1);
            Console.WriteLine("Totalkostnad: " + total + " kr");



        }
    }
}
