using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Clases_de_proyectos
{
    public class Paquetes 
    {
        public Paquetes()
        {

        }

        public int nroPaqueteNac { get; set; }
        public int nroPaqueteInterNac { get; set; }
        public string Nombre { get; set; }
        public double precio { get; set; }
        public double impuestos { get; set; }
        public int Cant_dias { get; set; }
        public DateTime Fecha_Viaje { get; set; }
        public bool Vigencia { get; set; } //existencia del paquete
        public int CuotasContadas { get; set; }
        public double Cotizacion_Dolar { get; set; }
        public bool visa { get; set; }
        public string Lugares { get; set; }

        //Paquetes Nacionales
        public Paquetes(int nroPaqueteNac, string Nombre, double precio, double impuestos, int Cant_dias, DateTime Fecha_Viaje, bool Vigencia, int CuotasContadas, string Lugares)
        {
            this.nroPaqueteNac = nroPaqueteNac;
            this.Nombre = Nombre;
            this.precio = precio;
            this.impuestos = impuestos;
            this.Cant_dias = Cant_dias;
            this.Fecha_Viaje = Fecha_Viaje;
            this.Vigencia = Vigencia;
            this.CuotasContadas = CuotasContadas;
            this.Lugares = Lugares;
            
        }

        //Paquete Internacionales   cot dolar y visa
        public Paquetes(int nroPaqueteInterNac, string Nombre, double precio, double impuestos, int Cant_dias, DateTime Fecha_Viaje, bool Vigencia, int CuotasContadas, double Cotizacion_Dolar, bool visa, string Lugares)
        {
            this.nroPaqueteInterNac = nroPaqueteInterNac;
            this.Nombre = Nombre;
            this.precio = precio;
            this.impuestos = impuestos;
            this.Cant_dias = Cant_dias;
            this.Fecha_Viaje = Fecha_Viaje;
            this.Vigencia = Vigencia;
            this.CuotasContadas = CuotasContadas;
            this.Cotizacion_Dolar = Cotizacion_Dolar;
            this.visa = visa;
            this.Lugares = Lugares;
            
        }

        public void MostrarPaquetesNac()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("********** PAQUETE NACIONAL **********");
            Console.WriteLine("**************************************");
            Console.WriteLine("********** PAQUETE NRO: " + nroPaqueteNac + " **********");
            Console.WriteLine("Nombre del Paquete: " + Nombre);
            Console.WriteLine("Fecha de inicio de viaje: " + Fecha_Viaje.ToString("ddd/MM/yyyy"));
            Console.WriteLine("Valor del Paquete : " + precio + "$");
            Console.WriteLine("Impuesto Aplicado: " + impuestos + "%");
            Console.WriteLine("Duracion del Paquete : " + Cant_dias + " dias");
            Console.WriteLine("DESTINO : " + Lugares);
            if (Vigencia == true)
                Console.WriteLine("El paquete se encuentra Vigente");
            if (Vigencia == false)
                Console.WriteLine("El paquete esta Vencido");
            if (CuotasContadas == 1)
                Console.WriteLine("El Paquete se paga al contado");
            else if (CuotasContadas == 3)
                Console.WriteLine("El Paquete se financia en 3 cuotas");
            else if (CuotasContadas == 6)
                Console.WriteLine("El Paquete se financia en 6 cuotas");
            else if (CuotasContadas == 12)
                Console.WriteLine("El Paquete se financia en 12 cuotas");
            Console.WriteLine("**********************************************");
            Console.WriteLine(" ");

        }
        public void MostrarPaquetesInterNac()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("********** PAQUETE INTERNACIONAL **********");
            Console.WriteLine("*******************************************");
            Console.WriteLine("********** PAQUETE NRO: " + nroPaqueteInterNac + " **********");
            Console.WriteLine("Nombre del Paquete: " + Nombre);
            Console.WriteLine("Fecha de inicio de viaje: " + Fecha_Viaje.ToString("dd/MM/yyyy"));
            Console.WriteLine("Valor del Paquete en dolares : " + precio + "USD");
            Console.WriteLine("Cotizacion del Dolar al dia : " + Cotizacion_Dolar);
            Console.WriteLine("Valor del Paquete en Pesos : " + precio*Cotizacion_Dolar + "$");
            Console.WriteLine("Impuesto Fijo Aplicado: " + impuestos );
            Console.WriteLine("Duracion del Paquete : " + Cant_dias + " dias");
            Console.WriteLine("DESTINO : " + Lugares);
            if (Vigencia == true)
                Console.WriteLine("El paquete se encuentra Vigente");
            if (Vigencia == false)
                Console.WriteLine("El paquete esta Vencido");
            if (CuotasContadas == 1)
                Console.WriteLine("El Paquete se paga al contado");
            else if (CuotasContadas == 3)
                Console.WriteLine("El Paquete se financia en 3 cuotas");
            else if (CuotasContadas == 6)
                Console.WriteLine("El Paquete se financia en 6 cuotas");
            if (visa== true)
            {
                Console.WriteLine("Requiere visa: Si");
            }
            else 
            {
                Console.WriteLine("Requiere visa: No");
            }
            Console.WriteLine("**********************************************");
            Console.WriteLine(" ");
        }

        public string ObtenerJSON()
        {
            return JsonSerializer.Serialize(this);
        }


    }
}
