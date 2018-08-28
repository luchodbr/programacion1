using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int min = -100;
            int max = 100;
            int enteroMax = int.MinValue;
            int enteroMin = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                string valor = Console.ReadLine();
                //
                Console.ReadKey();
                int.TryParse(valor, out int valorInt);
                if (Validacion.Validar(valorInt, min, max) == false)
                {
                   // Console.WriteLine(valor);
                    if (valorInt > enteroMax)
                    {
                        enteroMax = valorInt;
                    }
                    if (valorInt < enteroMin)
                    {
                        enteroMin = valorInt;
                    }
                    acumulador = acumulador + valorInt;
                }
                if (Validacion.Validar(valorInt, min, max) == true)
                {
                    Console.WriteLine("error");
                }
                

                Console.ReadKey();
            }
            int promedio = acumulador / 10;
            Console.Write("Valor maximo es: {0} y el valor minimo es {1} y el promedio es {2}", enteroMax, enteroMin ,promedio);
            Console.ReadKey();

        }
    }
}
