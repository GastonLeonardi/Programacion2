using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int Cuit { get; set; }
        public decimal Saldo { get; set; }

        public static Cliente operator +(Cliente Cliente1, Cliente CLiente2)
        {
            if (Cliente1.Cuit == CLiente2.Cuit)
            {
                return new Cliente(Cliente1.Nombre, Cliente1.Cuit, (Cliente1.Saldo - CLiente2.Saldo));
            }
            else
            {
                if (Cliente1.Saldo < CLiente2.Saldo)
                {
                    return new Cliente(Cliente1.Nombre, Cliente1.Cuit, Cliente1.Saldo);
                }
                else
                {
                    return new Cliente(CLiente2.Nombre, CLiente2.Cuit, CLiente2.Saldo);
                }
            }
        }

        public Cliente(string nombre, int cuit, decimal saldo)
        {
            Nombre = nombre;
            Cuit = cuit;
            Saldo = saldo;
        }

    }
}
