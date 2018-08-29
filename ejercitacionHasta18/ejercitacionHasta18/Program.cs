using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercitacionHasta18
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Luciano","Gil",40901792);
            //Alumno alumno2 = new Alumno();
            //Alumno alumno3 = new Alumno();
            Console.WriteLine("Ingrese nota 1 Alumno 1");
            string nota1String = Console.ReadLine();
            byte.TryParse(nota1String, out byte nota1);
            Console.WriteLine("Ingrese nota 2 Alumno 1");
            string nota2String = Console.ReadLine();
            byte.TryParse(nota1String, out byte nota2);
            alumno1.Estudiar(nota1, nota2);
            alumno1.CalcularFinal();
            Console.Write(alumno1.mostrar());
            Console.Read();



        }
    }
}
