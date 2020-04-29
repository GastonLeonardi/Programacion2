using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Computadora : Componente
    {
        public string DescripcionDelProcesador { get; set; }
        public int CantidadDeMemoriaRam { get; set; }
        public string NombreDelFabricante { get; set; }

        public Computadora(string marca, string modelo, int numeroDeSerie,string descripcionDelProcesador, int cantidadDeMemoriaRam, string nombreDelFabricante)
        {
            base.Marca = marca;
            base.Modelo = modelo;
            base.NumeroDeSerie = numeroDeSerie;
            base.Identificador = (marca + "-" + modelo + "-" + Convert.ToString(numeroDeSerie));
            DescripcionDelProcesador = descripcionDelProcesador;
            CantidadDeMemoriaRam = cantidadDeMemoriaRam;
            NombreDelFabricante = nombreDelFabricante;
        }


    }
}
