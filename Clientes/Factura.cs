using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Clases_de_proyectos
{
    public class Factura
    {
        public Factura()
        {
        
        }

     
        public int nroFactura { get; set; }

        //cuando un cliente hace un pedido se le asigna este valor para saber cuantos pedidos ya realizo
        public int nroPedido_Cliente { get; set; }

        public Clientes clientes { get; set; }
        public Paquetes paquetes { get; set; }
        public DateTime Fecha { get; set; }

        public Factura(int nroFactura, Clientes c , Paquetes p , DateTime F, int nroPedido_Cliente)
        {
            this.nroFactura = nroFactura;
            clientes = c;
            paquetes = p;
            this.Fecha = F;
        }

        public void mostrarDatos()
        {

            Console.WriteLine("********************************");
            Console.WriteLine("********* FACTURA NRO " + nroFactura + "*********");
            Console.WriteLine("*** DATOS CLIENTE ***");
            Console.WriteLine(clientes.nombre + " " + clientes.apellido);
            Console.WriteLine("*** PAQUETE SELECCIONADO ***");
            if (paquetes == null) { Console.WriteLine("*** SIN PAQUETE ASIGNADO ***"); }
            else
            {
                if (paquetes.nroPaqueteNac != 0) { Console.WriteLine("TIPO DE PAQUETE: NACIONAL"); }
                if (paquetes.nroPaqueteInterNac != 0) { Console.WriteLine("TIPO DE PAQUETE: INTERNACIONAL"); }
                Console.WriteLine(paquetes.Nombre);
                Console.WriteLine("******************");
                try
                {
                    if (paquetes.Vigencia == true) { Console.WriteLine("Estado de paquete: VIGENTE"); }
                    else { Console.WriteLine("Estado de paquete: NO VIGENTE"); }
                }
                catch (Exception) { Console.WriteLine("SIN PAQUETE"); }
                Console.WriteLine("******************");
                Console.WriteLine("*** FECHA Y HORA DE CREACION ***");
            }
            Console.WriteLine(Fecha);
            Console.WriteLine("********************************");
        }

     




    }
}
