using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica1_ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA QUE CALCULA EL INCREMENTO DE SUELDO DE UN EMPLEADO");
            Console.WriteLine("_____________________________________________________________");
            double sueldo, incremento;
            Console.WriteLine("SALARIO DEL EMPLEADO?");
            sueldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("_____________________________________________________________");
            incremento = sueldo * 0.40 + sueldo;
            Console.WriteLine("SE LE HA APLICADO UN 40% DE AUMENTO SALARIAL");
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("SU NUEVO SALARIO ES DE: " + incremento.ToString("N2"));
            Console.ReadKey();

        }
    }
}
