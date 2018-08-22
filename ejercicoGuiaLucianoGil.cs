using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numString;
            double cuadrado = 2;
            double cubo = 3;
            double resultadoCubo;
            double resultadoCuadrado;
            Console.Write("Ingrese un numero");
            numString = Console.ReadLine();
            double.TryParse(numString, out double num);
            if(num<=0)
            {
                Console.Write("ERROR, reingresar numero!");
            }
            resultadoCuadrado=Math.Pow(num, cuadrado);
            resultadoCubo=Math.Pow(num, cubo);
            Console.WriteLine("el resultado de la potencia en 2 es:{0} " +
                "y el resultado de la potencia en 3 es {1}  ", resultadoCuadrado,resultadoCubo);
            Console.ReadKey();

        }
    }
}
