using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Clases_de_proyectos
{
    public class RepoJSON
    {

        private string archivo; //ruta y nombre
        public RepoJSON(string nombrearchivo)
        {
            archivo = nombrearchivo;
        }

        public void LeerYDeserializarCLIENTES(out List<Clientes> listaDestino)
        {
            /**** INTENTAMOS LEER EL JSON DE CLIENTES DESDE UN ARCHIVO ****/
            StreamReader lectura_arch_clientes = null;
            try
            {
                lectura_arch_clientes = new StreamReader(archivo);
                listaDestino = JsonSerializer.Deserialize<List<Clientes>>(lectura_arch_clientes.ReadToEnd());
                lectura_arch_clientes.Close();
            }
            /**** SI NO EXISTE EL ARCHIVO DE CLIETES CREAMOS LA LISTA VACÍA ****/
            catch
            {
                listaDestino = new List<Clientes>();
            }
        }

        public void SerializarYGuardarCLIENTES(List<Clientes> listaFuente)
        {
            /**** GUARDAMOS TODA LA LISTA DE CLIENTES EN UN JSON EN EL ARCHIVO CLIENTES.JSON ****/
            StreamWriter escrituraClientes = new StreamWriter(archivo);
            escrituraClientes.Write(JsonSerializer.Serialize(listaFuente));
            escrituraClientes.Close();
       
        }

        public void LeerYDeserializarPAQUETES(out List<Paquetes> listaDestino)
        {
       
            StreamReader lectura_arch_paquetes = null;
            try
            {
                lectura_arch_paquetes = new StreamReader(archivo);
                listaDestino = JsonSerializer.Deserialize<List<Paquetes>>(lectura_arch_paquetes.ReadToEnd());
                lectura_arch_paquetes.Close();
            }
            
            catch
            {
                listaDestino = new List<Paquetes>();
            }
        }

        public void SerializarYGuardarPAQUETES(List<Paquetes> listaFuente)
        {
            
            StreamWriter escrituraPaquetes = new StreamWriter(archivo);
            escrituraPaquetes.Write(JsonSerializer.Serialize(listaFuente));
            escrituraPaquetes.Close();
        
        }

        public void LeerYDeserializarFACTURAS(out List<Factura> listaDestino)
        {
            
            StreamReader lectura_arch_facturas = null;
            try
            {
                lectura_arch_facturas = new StreamReader(archivo);
                listaDestino = JsonSerializer.Deserialize<List<Factura>>(lectura_arch_facturas.ReadToEnd());
                lectura_arch_facturas.Close();
            }
            
            catch
            {
                listaDestino = new List<Factura>();
            }
        }

        public void SerializarYGuardarFACTURAS(List<Factura> listaFuente)
        {
            
            StreamWriter escriturafactura = new StreamWriter(archivo);
            escriturafactura.Write(JsonSerializer.Serialize(listaFuente));
            escriturafactura.Close();
           
        }

        public void LeerYDeserializarPEDIDOS(out List<Pedidos> listaDestino)
        {

            StreamReader lectura_arch_pedidos = null;
            try
            {
                lectura_arch_pedidos = new StreamReader(archivo);
                listaDestino = JsonSerializer.Deserialize<List<Pedidos>>(lectura_arch_pedidos.ReadToEnd());
                lectura_arch_pedidos.Close();
            }
            catch
            {
                listaDestino = new List<Pedidos>();
            }
        }

        public void SerializarYGuardarPEDIDOS(List<Pedidos> listaFuente)
        {

            StreamWriter escriturapedido = new StreamWriter(archivo);
            escriturapedido.Write(JsonSerializer.Serialize(listaFuente));
            escriturapedido.Close();

        }


    }
}
