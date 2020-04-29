using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Practica_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Global Instancia = Global.OBtenerInstancia();
            
            Instancia.AgregarProducto("Intel","Aguacate",412,2012,23);
            Instancia.AgregarProducto("AMd","Chocolate",455,"Rapdio",2,"Gaston");
            Instancia.ObtenerDescripcion();
            Console.WriteLine("Ingrese IDentificador: Ejemplo (Marca-Modelo-NumeroDeSerie)");
            string Identificador = Console.ReadLine();
            Instancia.BorrarProducto(Identificador);
            Instancia.ObtenerDescripcion();


            Console.ReadKey();
            
        }
    }
}
