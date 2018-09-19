using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleNegocio
{
    public enum EPuesto
    {
        caja1,
        caja2
    }
    public class PuestoAtencion
    {
        private EPuesto puesto;
        static private int numeroActual;

        public static int NumeroActual { get => numeroActual+=1 ; }

        static PuestoAtencion()
        {
            numeroActual = 0;

        }

        bool Atender(Cliente cli)
        {
            bool retorno = false;
            if (cli != null)
            {
                Thread.Sleep(3000);
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="puesto"></param>
        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }
    }
}



