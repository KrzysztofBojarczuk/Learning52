using System;

namespace przevyta_odległość
{
    class Program
    {
        static void Main(string[] args)
        {
            double odgległość = 0;
            Console.WriteLine("Z jaką prędkością jechał pojazd?");
            double speed = double.Parse(Console.ReadLine());

            Console.WriteLine("Jak długo trwała podróż?");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Godzina              Przebyta odległość");
            Console.WriteLine("---------------------------------------");

            for (int  i = 1; i<= hours; i++)
            {
                
                odgległość = speed * i;
                Console.WriteLine($"{i}                {odgległość}");
            }
        }
    }
}
