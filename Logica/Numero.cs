using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Numero
    {
        public decimal Numero1 { get; set; }
        public static decimal operator /(Numero Numero1, Numero Numero2)
        {
            decimal Resultado = Numero1.Numero1 / Numero2.Numero1;
            decimal ResultadoFinal = Resultado - Math.Truncate(Resultado);
            return ResultadoFinal;
        }

        public Numero(decimal numero1)
        {
            Numero1 = numero1;
        }
    }
}
