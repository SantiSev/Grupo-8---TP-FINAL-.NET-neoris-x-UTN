using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Clases_de_proyectos
{
    public class Clientes
    {

        public Clientes() //por defecto 
        {
          
        }

       

  
        public int nroCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string nacionalidad { get; set; }
        public string provincia { get; set; }
        public string direccion { get; set; }
        public string razon_social { get; set; }
        public string cuit { get; set; }
        public int DNI { get; set; }

        //clientes Consumidor Final
        public Clientes(int nroCliente, string nombre, string apellido, int DNI, string telefono, string nacionalidad, string provincia, string direccion) 
        {
            this.nroCliente = nroCliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI  = DNI;
            this.telefono  = telefono;
            this.nacionalidad  =  nacionalidad;
            this.provincia  = provincia;
            this.direccion  = direccion;


        }

        //clientes Corporativos
        public Clientes(int nroCliente, string nombre, string apellido, int DNI, string telefono, string nacionalidad, string provincia, string direccion, string razon_social, string cuit) 
        {
            this.nroCliente = nroCliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = DNI;
            this.telefono = telefono;
            this.nacionalidad = nacionalidad;
            this.provincia = provincia;
            this.direccion = direccion;
            this.razon_social = razon_social;
            this.cuit = cuit;
            

        }

        public void MostrarClientesConsFinal()
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("********** CLIENTE CONSUMIDOR FINAL **********");
            Console.WriteLine("**********************************************");
            Console.WriteLine("********** ID CLIENTE: " + nroCliente + " **********");
            Console.WriteLine("nombre: " + nombre);
            Console.WriteLine("apellido: " + apellido);
            Console.WriteLine("DNI: " + DNI);
            Console.WriteLine("telefono: " + telefono);
            Console.WriteLine("nacionalidad: " + nacionalidad);
            Console.WriteLine("provincia: " + provincia);
            Console.WriteLine("direccion: " + direccion);
            Console.WriteLine("**********************************************");
            Console.WriteLine(" ");
        }

        public void MostrarClientesCorp()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("********** CLIENTE CORPORATIVO **********");
            Console.WriteLine("*****************************************");
            Console.WriteLine("********** ID CLIENTE: " + nroCliente + " **********");
            Console.WriteLine("nombre: " + nombre);
            Console.WriteLine("apellido: " + apellido);
            Console.WriteLine("DNI: " + DNI);
            Console.WriteLine("telefono: " + telefono);
            Console.WriteLine("nacionalidad: " + nacionalidad);
            Console.WriteLine("provincia: " + provincia);
            Console.WriteLine("direccion: " + direccion);
            Console.WriteLine("razon social: " + razon_social);
            Console.WriteLine("cuit: " + cuit);
            Console.WriteLine("**********************************************");
            Console.WriteLine(" ");

        }

        public string ObtenerJSON()
        {
            return JsonSerializer.Serialize(this);
        }


    }
}
