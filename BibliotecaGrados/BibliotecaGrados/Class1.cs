using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGrados
{
    public class Fahrenheit
    {
        private double grados;
        private int pepe;
        private string ubicacion;

        public string Ubicacion
        {
            get
            {
                return this.ubicacion;
            }
            set
            {
                this.ubicacion = string.IsNullOrEmpty(value) ? "Desconocido" : value;
                //if (!string.IsNullOrEmpty(value))
                //{
                //    this.ubicacion = value;

                //}
            }
        }
        public int Pepe
        {
            get
            {
                return this.pepe;
            }
            set
            {
                if (value >= 0) this.pepe = value;
            }
        }
        public double Grados
        {
            get
            {
                return this.grados;
            }

        }

        private Fahrenheit()
        {
            this.pepe = 1;
            this.pepe = 1;
        }

        public Fahrenheit(double grados) : this()
        {
            this.grados = grados;
        }

        public Fahrenheit(double grados, string ubicacion) : this(grados)
        {
            this.ubicacion = ubicacion;
        }

        public Fahrenheit(string ubicacion) : this()
        {
            this.ubicacion = ubicacion;
        }
    }

}