using System;
using System.IO;

namespace AppProyectoFinal
{
    class OperacionesBasicas : ObjetosPrincipales
    {
        public static void metodoOperacionesBasicas(StreamWriter sw, int opcion)
        {
            Console.WriteLine("Escribe a cantidad de numeros que quieres trabajar: ");
            double[] arreglo = new double[int.Parse(Console.ReadLine())];
            double resultado = 0;
            //resultado = Utilidades.Arreglo(arreglo, opcion);
            OperacionesBasicas ejecutor = new OperacionesBasicas();
            switch (opcion)
            {
                case 1: //SUMA
                    resultado = Utilidades.Arreglo(arreglo, 1);
                    break;

                case 2: //RESTA
                    resultado = Utilidades.Arreglo(arreglo, 2);
                    break;

                case 3: //MULTIPLICACIÓN
                    resultado = Utilidades.Arreglo(arreglo, 3);
                    break;

                case 4: //DIVISIÓN
                    resultado = Utilidades.Arreglo(arreglo, 4);
                    break;
            }

            Imprimir.imprimirCalculo(arreglo, resultado, sw);
        }



        public double suma(double[] arreglo)
        {
            foreach (int i in arreglo)
            { resultado += i; }
            return resultado;
        }

        public double resta(double[] arreglo)
        {
            resultado = arreglo[0];
            for (int i = 1; i < arreglo.Length; i++)
            { resultado -= arreglo[i]; }
            return resultado;
        }

        public double multiplicacion(double[] arreglo)
        {
            resultado = 1;
            for (int i = 0; i < arreglo.Length; i++)
            { resultado = resultado * arreglo[i]; }
            return resultado;
        }

        public double division(double[] arreglo)
        {
            resultado = arreglo[0];
            for (int i = 1; i < arreglo.Length; i++)
            { resultado = resultado / arreglo[i]; }
            return resultado;
        }
    }
}
