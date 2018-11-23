using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PEDIR POR TECLADO EL LADO DE UN CUADRADO");
            Console.WriteLine("=========================================");
            double Ldcuadrado, perimetro=0, resultado;
            Console.WriteLine("INGRESE EL LADO DEL CUADRADO");
            Ldcuadrado = Convert.ToDouble(Console.ReadLine());
            perimetro = Ldcuadrado * 4;
            Console.WriteLine("SU PERIMETRO ES:" + perimetro);
            Console.ReadKey();

        }
    }
}
