using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercitacionHasta18
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            if (this.nota1 > 4 && this.nota2 > 4)
            {
                Random random = new Random();
                this.notaFinal = random.Next(10);

            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.notaFinal = -1;
        }

        public string mostrar()
        {
            if (notaFinal == -1)
            {
                return string.Format("el nombre es {0} el apellido es {1} el legajo es {2} y la nota final es 'Alumno desaprobado' ", nombre, apellido, legajo);
            }
            return string.Format("el nombre es {0} el apellido es {1} el legajo es {2} y la nota final es {3}", nombre, apellido, legajo, notaFinal);


        }
    }
}
