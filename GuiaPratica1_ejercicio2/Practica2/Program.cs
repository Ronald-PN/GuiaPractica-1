using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console .WriteLine("PROGRAMA CALCULA LA MASA DEL AIRE");
            Console.WriteLine("____________________________________");
            double masa, presion, volumen, temperatura;
            Console.WriteLine("INGRESE LA PRESION");
            presion = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("____________________________________");
            Console.WriteLine("INGRESE LA TEMPERATURA");
            temperatura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("____________________________________");
            Console.WriteLine("INGRESE EL VOLUMEN");
            volumen = Convert.ToDouble(Console.ReadLine());
            masa = (presion * volumen) / (0.37 * (temperatura + 460));
            Console.WriteLine("MASA: " + masa);
            Console.ReadKey();
        }
    }
}
