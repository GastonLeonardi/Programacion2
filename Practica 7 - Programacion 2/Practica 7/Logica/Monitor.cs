using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Monitor : Componente
    {
        public int AdeFabiracion { get; set; }
        public bool EsNuevo { get; set; }
        public Nullable<int> Pulgadas { get; set; }

        public Monitor(int adeFabiracion, int pulgadas)
        {
            AdeFabiracion = adeFabiracion;
            if (adeFabiracion == DateTime.Now.Year)
            {
                EsNuevo = true;
            }
            else
            {
                EsNuevo = false;
            }
            Pulgadas = pulgadas;
        }

        public Monitor(string marca, string modelo, int numeroDeSerie, int adeFabiracion, Nullable<int> pulgadas)
        {
            base.Modelo = modelo;
            base.Marca = marca;
            base.NumeroDeSerie = numeroDeSerie;
            base.Identificador = (marca + "-" + modelo + "-" + Convert.ToString(numeroDeSerie));
            AdeFabiracion = adeFabiracion;
            if (adeFabiracion == DateTime.Now.Year)
            {
                EsNuevo = true;
            }
            else
            {
                EsNuevo = false;
            }
            Pulgadas = pulgadas;
        }
    }
}
