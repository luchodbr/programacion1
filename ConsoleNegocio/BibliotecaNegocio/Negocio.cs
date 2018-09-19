using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNegocio
{
    class Negocio
    {
        PuestoAtencion caja;
        string nombre;
        //QUEUE agfrega los elementos al final de la cola
        Queue<Cliente> clientes;

        public Queue<Cliente> Clientes
        {
            get
            {
                return clientes;
            }
            set
            {
                this.clientes = value;
            }
        }
 
            private Negocio()
        {
            //this.caja = EPuesto.caja1;
        }

        public Cliente this [int i]
        {
            get
            {
                Cliente proximoCliente = null;
                foreach(Cliente item in this.clientes)
                {  if (item.Numero == i)
                        proximoCliente = item;

                }
                return proximoCliente;
            }

            set
            {
                bool encontro = false;
                foreach (Cliente item in this.clientes)
                {
                    if(item.Numero == i)
                    {
                        encontro = true;
                    }
                }
                if(!encontro)
                {
                    this.clientes.Enqueue(value);
                }

            }
        }
    }
}

