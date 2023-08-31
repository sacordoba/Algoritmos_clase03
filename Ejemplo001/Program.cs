using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            string cadena = "Saludo 2";

            int[] numeros = new int[4];
            int[] numeros1 = new int[] {10,20,30,40} ;
            List<int> lista = new List<int>();
            
            for (int i = 0; i < 4; i++)
            {
                numeros[i] = numeros1[3-i];
                lista.Add(numeros1[3-i]);
            }

            foreach(int item in lista) {
                Console.WriteLine("El nº es: " + item);
                Console.WriteLine("El nº es: {0}", item);
                Console.WriteLine($"El nº es: {item}");
            }

            Saludo(cadena);
            //Thread.Sleep(10000);
            Console.ReadKey();

        }

        private static void Saludo(string cadena)
        {
            Console.WriteLine(cadena);
        }

        private static void Saludo()
        {
            Console.WriteLine("Hola Mundo...Otra vez...");
        }
    }
}
