using System;

namespace Matrizes
{
    public class Matrizes
    {
        static void Main(string[] args)
        {
            //criacao de matriz e classifica-las
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted....");
            Array.Sort(pallets);
            foreach(var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            //inverter a ordem dos paletes
            Console.WriteLine("");
            Console.WriteLine("Reversed.....");
            Array.Reverse(pallets);
            foreach(var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
        }
    }
}