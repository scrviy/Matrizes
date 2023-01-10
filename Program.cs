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

            //Limpar itens
            string[] pallets2 = { "B24", "A21", "B22", "A23" };
            Console.WriteLine("");

            Console.WriteLine($"Before: {pallets[0].ToLower()}");
            Array.Clear(pallets, 0, 2);

            if (pallets[0] != null)
                Console.WriteLine($"After: {pallets[0].ToLower()}");

            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach(var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
        }
    }
}