using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            int[] numeros1 = new int[] { 10, 20, 30, 40 };
            List<int> lista = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                numeros[i] = numeros1[3 - i];
                lista.Add(numeros1[3 - i]);
            }

            //lista.Remove(30);

            foreach (int item in lista)
            {
                Console.WriteLine("El nº es: " + item);
                Console.WriteLine("El nº es: {0}", item);
                Console.WriteLine($"El nº es: {item}");
            }

            Console.ReadKey();

        }
    }
}
