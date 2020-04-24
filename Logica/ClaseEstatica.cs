using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    static class ClaseEstatica
    {   
        const decimal Constatne = 2.12m;
        public static decimal DevovlerGradosCelsius(decimal GradosFahrenheit)
        {
            return (GradosFahrenheit / Constatne);
        } //Act11
        public static decimal DevolverGradosFahrenheit(decimal GradosCelsius)
        {
            return (GradosCelsius * Constatne);
        } //Act11
    }
}
