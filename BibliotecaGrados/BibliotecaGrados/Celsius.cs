using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrados
{
    public class Celsius
    {
        private double grados;
        
        public Celsius(double grados)
        {
            this.grados = grados;
        }

        public double Grados { get => grados; set  { grados = value; } }

        public static explicit operator Celsius (Fahrenheit fahrenheit)
        {
           return new Celsius( (fahrenheit.Grados - 32) * (5 / 9));
        }
    }
}
