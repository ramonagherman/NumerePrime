using System;
using System.Linq;

namespace NumerePrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = ReadNumber("Afisare numere prime pana la nr: ");
            Nrprim(n);
        }
        public static void Nrprim(int n)
        {
            int[] array = new int[n];

            for (int i = 1; i <= n - 1; i++)
            {
                array[i] = 1;
            }

            for (int i = 2; i <= n - 1; i++)
            {
                if (array[i] == 1) // i este prim => multiplii pana la N vor fi zero
                {
                    for (int j = 2; j * i <= n - 1; j++)
                    {
                        array[i * j] = 0;
                    }
                }
            }

            Console.WriteLine();
            Console.Write($"Numerele prime sunt:");
            for (int i = 1; i <= n - 1; i++)
            {
                if (array[i] == 1)
                {
                    Console.Write($" {i} ");
                }
            }
            Console.WriteLine();
        }

        static int ReadNumber(string label)
        {
            Console.Write(label);
            string value = Console.ReadLine();
            int valueAsNumber = Convert.ToInt32(value);
            return valueAsNumber;
        }
    }
}
