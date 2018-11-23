using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaPractica1_ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA QUE CALCULA EL % DE ESTUDIANTES HOMBRES Y MUJEERES DEL DIPLOMADO");
            Console.WriteLine("____________________________________________________________________________");
            double resultadoM=0, resultadoH=0;
            int hombres, mujeres, cantidad =0;
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("INSERTE LA CANATIDAD DE ESTUDIANTES DEL DIPLOMADO?");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("CUANTOS  HOMBRES HAY EN EL DIPLOMADO?");
            hombres = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("CUANTOS MUJERES HAY EN EL DIPLOMADO?");
            mujeres = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("____________________________________________________________________________");
            resultadoH = hombres*100 /cantidad;
            resultadoM = mujeres*100 /cantidad;
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("EL PORCENTAJE DE HOMBRES ES: " + resultadoH+ "%" );
            Console.WriteLine("EL PORCENTAJE DE MUJERES ES: " + resultadoM + "%");
            Console.ReadKey();

        }
    }
}
