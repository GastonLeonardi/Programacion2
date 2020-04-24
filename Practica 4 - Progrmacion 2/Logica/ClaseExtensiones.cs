using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Logica
{
    public static class ClaseExtensiones
    {
        public static int CantidadDePalabras(this string frase)
        {
            string [] array = frase.Split();
            int Cantidad = array.Count();
            return Cantidad;

            /* Otro Ejemplo mas resumido
             return frase.Split().Length;
            */
        }// Act1
        public static int CantidadDePalabras(this string frase, char Separador)
        {
            string[] array = frase.Split(Separador);
            int Cantidad = array.Length;
            return Cantidad;
           
            /*Otro ejemplo mas resumido
            retunr frase.Split(Separador).Length;
            */

        }// Act2
        public static decimal CalcularDiferenciaSegundos(this DateTime Fecha1, DateTime Fecha2)
        {
            var SegundosResultantes = (Fecha2 - Fecha1).TotalSeconds;
            decimal Segundos = Convert.ToDecimal(SegundosResultantes);
            return Segundos;

        }// Act3
        public static decimal DevolverPromedio(this List<int> ListaDeEnteros)
        {
            int Suma = 0;
            foreach (var item in ListaDeEnteros)
            {
                Suma = Suma + item;
            }
            decimal Promedio = (Suma / ListaDeEnteros.Count);
            return Promedio;
        }// Act4
        public static int[] DevolverSumaYresta(this List<int> ListaDeEnteros)
        {
            int Suma = 0;
            int Resta = 0;
            foreach (var item in ListaDeEnteros)
            {
                if (item % 2 == 0)
                {
                    Suma = Suma + item;
                }
                else
                {
                    if (Resta == 0)
                    {
                        Resta = item;
                    }
                    else
                    {
                        Resta = Resta - item;
                    }
                }
            }
            int[] Restultados = new int[] { Suma, Resta};
            return Restultados;
        }// Act5
        public static DateTime DevolverFecha(this string Fecha)
        {
            try
            {
                DateTime Dato = DateTime.Parse(Fecha);
                return Dato;
               
            }
            catch (FormatException Exepcion)
            {
                DateTime Dato = DateTime.MinValue;
                return Dato;
            }

        }// Act6
        public static string DevolverStringInvertido(this string Dato)
        {
            char[] Cadena = Dato.ToCharArray();
            Array.Reverse(Cadena);
            return new string(Cadena);
        }// Act7
        public static string DevovlerString(this string[] ArrayString)
        {
            string NuevoString = string.Join("-",ArrayString);
            return NuevoString;
        }// Act8
        public static bool Verifiacion(this string Emial)
        {
            /*
            MatchCollection encontrado = Regex.Matches(Emial, "@");
            if (encontrado.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            */

            Regex regexCuit = new Regex("(@)(.+)$");
            return regexCuit.IsMatch(Emial); //Esta instruccion devuelve un valor booleano.

        }// Act 9
        public static decimal DevovlerEntero(this int Entero1, int Entero2) //Act11
        {
            return  (Entero1 - Entero2);
        }



    }
}
