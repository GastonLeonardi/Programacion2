using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Global
    {
        public EventHandler Accion;
        private static Global Instancia;
        private List<Componente> ListaComponente { get; set; }

        private Global()
        {
            ListaComponente = new List<Componente>();
        }
        public static Global OBtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new Global();
                return Instancia;
            }
            else
            {
                return Instancia;
            }
        }
        public void AgregarProducto(string modelo, string marca, int numeroDeSerie,string descripcion, int cantidadRam, string nombreFabriacnte)
        {
            Computadora nuevaComputadora = new Computadora(modelo, marca, numeroDeSerie, descripcion, cantidadRam,nombreFabriacnte);
            Componente nuevoComponente = nuevaComputadora as Componente;
            ListaComponente.Add(nuevoComponente);
            Accion(this, new EventArgs());  
        }
        public void AgregarProducto(string modelo, string marca, int numeroDeSerie, int aFabricacion, Nullable<int> pulgadas)
        {
            Monitor nuevoMonitor = new Monitor(modelo, marca, numeroDeSerie, aFabricacion, pulgadas);
            Componente nuevoComponete = nuevoMonitor as Componente;
            ListaComponente.Add(nuevoComponete);
            Accion(this, new EventArgs());
            

        }
        public void BorrarProducto(string identificador)
        {
            if (Verificacion(identificador) == true)
            {
                ListaComponente.Remove(ListaComponente.Find(x => x.Identificador == identificador));
            }
            else
            {
                Console.WriteLine("El Componente no exite");
            }

        }
        public bool Verificacion(string identificador)
        {
            bool existe = ListaComponente.Exists(x =>x.Identificador == identificador);
            return existe;
            
        }
        public void ObtenerDescripcion()
        {
            foreach (var item in ListaComponente)
            {
                if (item is Monitor)
                {
                    Monitor monitor = item as Monitor;
                    Console.WriteLine("Monitor: {0} - {1} - {2}",monitor.Marca,monitor.Modelo,monitor.Pulgadas);
                }
                else
                {
                    Computadora computador = item as Computadora;
                    Console.WriteLine("Computadora: {0} - {1} - {2} - {3} Ram - Fabricante: {4} ", computador.Marca, computador.Modelo, computador.DescripcionDelProcesador, computador.CantidadDeMemoriaRam, computador.NombreDelFabricante);
                }
            }
        }
        public static void MensajeHandlerEvent(object sender, EventArgs args)
        {
            
        }

    }
}
