using System;
using System.Collections.Generic;
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
            Saludo();
            //Thread.Sleep(10000);
            Console.ReadKey();

        }

        private static void Saludo()
        {
            Console.WriteLine("Hola Mundo...Otra vez...");
        }
    }
}
