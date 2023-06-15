using System;
using System.IO;
namespace AppProyectoFinal
{
    public static class Imprimir
    {
        public static void imprimirCalculo(double[] arreglo, double resultado, StreamWriter sw)
        {
            Console.WriteLine("El resultado es: " + resultado);
            string formatoHistorial = "";
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (i == 0) { formatoHistorial += arreglo[i]; continue; }
                formatoHistorial += ", " + arreglo[i];
            }
            sw.WriteLine("El resultado de " + formatoHistorial + " es " + resultado + DateTime.Now);
        }

        public static void imprimirConversiones(StreamWriter sw, double valor, double resultado, string accion)
        {
            Console.WriteLine("El equivalente de: " + valor + accion + resultado + " Plg.");
            sw.WriteLine("El equivalente de: " + valor + accion + resultado + " Plg." + DateTime.Now);
        }

        public static void imprimirIMC(StreamWriter sw, double kilos, double altura, double imc)
        {
            Console.WriteLine("Tu índice de Masa Corporal (Peso = " + kilos + ", Altura = " + altura + ") es de: " + imc);
            sw.WriteLine("Tu índice de Masa Corporal (Peso = " + kilos + ", Altura = " + altura + ") es de: " + imc + DateTime.Now);
        }

        public static void imprimirTriangulo(StreamWriter sw, double valor1, double valor2, double resultado)
        {
            Console.WriteLine("El área del Triangulo (Base = " + valor1 + ", Altura = " + valor2 + ") es: " + resultado + ".");
            sw.WriteLine("El área del Triangulo (Base = " + valor1 + ", Altura = " + valor2 + ") es: " + resultado + "." + DateTime.Now);
        }
        public static void imprimirCuadrado(StreamWriter sw, double lado, double resultado)
        {
            Console.WriteLine("El área del Cuadrado (Lado = " + lado + ") es: " + resultado + ".");
            sw.WriteLine("El área del Cuadrado (Lado = " + lado + ") es: " + resultado + "." + DateTime.Now);
        }
        public static void imprimirRectangulo(StreamWriter sw, double lado, double ladoBse, double resultado)
        {
            Console.WriteLine("El área del Rectángulo (Base = " + ladoBse + ", Altura = " + lado + ") es: " + resultado + ".");
            sw.WriteLine("El área del Rectángulo (Base = " + ladoBse + ", Altura = " + lado + ") es: " + resultado + "." + DateTime.Now);
        }
        public static void imprimirCirculo(StreamWriter sw, double radio, double resultado)
        {
            Console.WriteLine("El área del Circulo (Radio = " + radio + ") es: " + resultado + ".");
            sw.WriteLine("El área del Circulo (Radio = " + radio + ") es: " + resultado + "." + DateTime.Now);
        }
    }
}
//El archivo de texto con el historial se guarda en la carpeta Debug dentro de la del programa.