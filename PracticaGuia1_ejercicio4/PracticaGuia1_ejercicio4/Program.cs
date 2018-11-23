using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGuia1_ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, peso;
            Console.WriteLine("ESTE PROGRAMA COVERTIRA LA CANTIDAD DE PESOS INTRODUCIDOS EN DOLAR");
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("CUANTOS PESOS QUIERES INTRODUCIR?");
            peso = Convert.ToDouble(Console.ReadLine());
            dolar = peso / 50;
            Console.WriteLine("DOLAR: " + dolar);
            Console.ReadKey();
        }
    }
}
