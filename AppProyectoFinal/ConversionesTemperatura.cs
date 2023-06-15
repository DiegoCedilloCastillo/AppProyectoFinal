using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProyectoFinal
{
    public class ConversionesTemperatura : ObjetosPrincipales
    {
        public static void metodoTemperaturas(StreamWriter sw, int opcion)
        {
            ConversionesTemperatura grados = new ConversionesTemperatura();
            Console.WriteLine("Ingresa la temperatura a convertir:");
            double valor = double.Parse(Console.ReadLine());
            grados.Valor1 = valor;

            switch (opcion)
            {
                case 1: { grados.resultado = OpCentigradosFarenheit(sw, grados.valor1); } break;
                case 2: { grados.resultado = OpFarenheitCentigrados(sw, grados.valor1); } break;
                case 3: { grados.resultado = OpFarenheitKelvin(sw, grados.valor1); } break;
                case 4: { grados.resultado = OpKelvinFarenheit(sw, grados.valor1); } break;

            }
        }
        public static double OpCentigradosFarenheit(StreamWriter sw, double valor) //Centígrados a Fahrenheit
        {
            double[] valorMultiplicar = new double[3] { valor, 9, 0.2 };
            double[] valorSumar = new double[2] { Utilidades.Arreglo(valorMultiplicar, 3), 32 };
            double resultado = Utilidades.Arreglo(valorSumar, 1);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Centígrados en Fahrenheit es de: ");
            return resultado;
        }


        public static double OpFarenheitCentigrados(StreamWriter sw, double valor) //Fahrenheit a Centígrados
        {
            double[] valorRestar = new double[2] { valor, 32 };
            double[] valorMultiplicar = new double[3] { Utilidades.Arreglo(valorRestar, 2), 5, 0.11 };
            double resultado = Utilidades.Arreglo(valorMultiplicar, 3);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Fahrenheit en Centígrados es de: ");
            return resultado;
        }


        public static double OpFarenheitKelvin(StreamWriter sw, double valor) //Fahrenheit a Kelvin
        {
            double[] valorRestar = new double[2] { valor, 32 };
            double[] valorMultiplicar = new double[3] { Utilidades.Arreglo(valorRestar, 2), 5, 0.11 };
            double[] valorSUmar = new double[2] { Utilidades.Arreglo(valorMultiplicar, 3), 273.15 };
            double resultado = Utilidades.Arreglo(valorSUmar, 1);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Fahrenheit en Kelvin es de: ");
            return resultado;
        }


        public static double OpKelvinFarenheit(StreamWriter sw, double valor) //Kelvin a Fahrenheit
        {
            double[] valorRestar = new double[2] { valor, 273.15 };
            double[] valorMultiplicar = new double[3] { Utilidades.Arreglo(valorRestar, 2), 5, 0.11 };
            double[] valorSUmar = new double[2] { Utilidades.Arreglo(valorMultiplicar, 3), 32 };
            double resultado = Utilidades.Arreglo(valorSUmar, 1);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Kelvin en KeFarenheitlvin es de: ");
            return resultado;
        }
    }
}
