using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt första tal");
            string tal1 = Console.ReadLine();
            Console.WriteLine("Skriv in ditt andra tal");
            string tal2 = Console.ReadLine();

            int sifra = int.Parse(tal1);
            int sifra2 = int.Parse(tal2);   

            Console.WriteLine("Välj ett av följande alternativ");
            Console.WriteLine("1. Subtrahera ett tal med ett annat");
            Console.WriteLine("2. Dividera första talet med det andra");
            Console.WriteLine("3. Avsluta progamet");
            string alternativ = Console.ReadLine();

            int alternativ2 = int.Parse(alternativ);    
            
            while (alternativ2 < 3)
            {
                if (alternativ2 == 2)
                {
                    Console.WriteLine("Ditt svar blev " + sifra / sifra2) ;
                    break;
                }
                else if (alternativ2 == 1)
                {
                    Console.WriteLine($"Ditt svar blev { +  sifra - sifra2}");
                    break;
                }
            } 
            if (alternativ2 == 3)
            {
                Console.WriteLine("Programet avslutas nu");
            }   

        }
    }
}

