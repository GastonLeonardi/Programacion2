using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace Practica4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Provar Act1
            string palabra = "hola me llamo gaston.";
            Console.WriteLine(palabra.CantidadDePalabras());

            //Provar Act3
            DateTime data1 = DateTime.Now;
            DateTime data2 = new DateTime(2020, 5, 17, 12, 00, 00);
            var SegundosResultantes = ClaseExtensiones.CalcularDiferenciaSegundos(data1, data2);
            Console.WriteLine(SegundosResultantes);

            //Provar Act4
            List<int> ListaDeEnteros = new List<int>();
            ListaDeEnteros.Add(2);
            ListaDeEnteros.Add(5);
            ListaDeEnteros.Add(7);
            ListaDeEnteros.Add(10);
            ListaDeEnteros.Add(6);
            ListaDeEnteros.Add(2);
            Console.WriteLine(ListaDeEnteros.DevolverPromedio());

            //Provar Act5
            int[] Resultados = ListaDeEnteros.DevolverSumaYresta();
            foreach (var item in Resultados)
            {
                Console.WriteLine(item);
            }

            //Provar Act 6
            string FechaAConvertir = ("Jun, 8, 2008");
            Console.WriteLine(FechaAConvertir.DevolverFecha());
            string FechaAConvertir2 = ("Gaston");
            Console.WriteLine(FechaAConvertir2.DevolverFecha());

            //Provar Act 7
            string StringAinvertir = ("Gaston Como estas?");
            Console.WriteLine(StringAinvertir.DevolverStringInvertido());

            //Provar Act 8
            string[] ArrayString = new string[3] { "hola", "Gaston", "ingenieria"};
            Console.WriteLine(ArrayString.DevovlerString());

            //Provar Act 9
            string Email = ("gaston.leonardi@hotmail.com");
            Console.WriteLine(Email.Verifiacion());
            string Email2 = ("gaston.leonardihotmail.com");
            Console.WriteLine(Email2.Verifiacion());

            //Provar Act 10
            Cliente Cliente1 = new Cliente("Gaston",41288166,1000);
            Cliente Cliente2 = new Cliente("Agustin",41288166,5000);

            Cliente ClienteNuevo = Cliente1 + Cliente2;
            Console.WriteLine(ClienteNuevo.Nombre + " " + ClienteNuevo.Cuit + " " + ClienteNuevo.Saldo);

            //Provar Act13
            Numero Numero1 = new Numero(5);
            Numero Numero2 = new Numero(7);

            decimal NumeroResultado = Numero1 / Numero2;
            Console.WriteLine(Convert.ToString(NumeroResultado));
            Console.ReadKey();

        }
    }
}
