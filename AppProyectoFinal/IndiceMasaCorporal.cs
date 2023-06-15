using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProyectoFinal
{
    class IndiceMasaCorporal : ObjetosPrincipales
    {
        public void IndiceMC(StreamWriter sw)
        {
            IndiceMasaCorporal imc = new IndiceMasaCorporal();
            Console.WriteLine("Ingresa tu peso: ");
            imc.Valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu estatura: ");
            imc.Valor2 = double.Parse(Console.ReadLine());
            double[] valores = new double[2] { imc.valor1, Math.Pow(imc.Valor2, 2) };
            imc.resultado = Utilidades.Arreglo(valores, 4);
            Imprimir.imprimirIMC(sw, imc.Valor1, imc.valor2, imc.resultado);
        }
    }
}
