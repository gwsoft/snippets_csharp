using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class BinarySignal
    {
        static void Main(string[] args)
        {
            RandomSignal();
        }

        private static void RandomSignal()
        {
            Random liczba = new Random();
            Console.Write("Binary number (8-bits):");
            for (int x = 0; x < 8; x++)
            {
                Console.Write(liczba.Next(2));
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(' '); Console.Write('\u250c'); Console.Write('\u2500'); Console.Write('\u2510'); Console.WriteLine();
            Console.Write('\u2500'); Console.Write('\u2518'); Console.Write(' '); Console.Write('\u2514'); Console.WriteLine();
        }
    }
}
