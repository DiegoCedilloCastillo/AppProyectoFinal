using System;
using System.IO;
using System.Linq;

namespace AppProyectoFinal
{
    class CalculosVariados : ObjetosPrincipales
    {
        public static void calculo(StreamWriter sw, int opcion)
        {
            Console.Clear();
            Console.WriteLine("Escribe a cantidad de columnas de la matriz: ");
            int columnas = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe a cantidad de de filas de la matriz: ");
            int filas = int.Parse(Console.ReadLine());
            double[,] matriz = new double[columnas, filas];
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    Console.WriteLine("Ingrese un valor: ");
                    matriz[i, j] = double.Parse(Console.ReadLine());
                }
            }

            switch (opcion)
            {
                case 1: { promedio(matriz, sw); } break;
                case 2: { desviacionEstandar(matriz, sw); } break;
                case 3: { mediana(matriz, sw); } break;
                case 4: { moda(matriz, sw); } break;
            }
        }

        public static void promedio(double[,] matriz, StreamWriter sw)
        {
            double[] arreglo = ConvertirMatrizArreglo(matriz);
            double sumatoria = Utilidades.Arreglo(arreglo, 1);
            double cantidad = arreglo.Count();
            double[] valores = new double[2] { sumatoria, cantidad };
            double resultado = Utilidades.Arreglo(valores, 4);
            Imprimir.imprimirCalculo(arreglo, resultado, sw);
        }

        public static void desviacionEstandar(double[,] matriz, StreamWriter sw)
        {
            double[] arreglo = ConvertirMatrizArreglo(matriz);
            double sum = arreglo.Sum(d => Math.Pow(d - arreglo.Average(), 2));
            double[] valores = new double[2] { Math.Sqrt(sum), arreglo.Count() };
            double resultado = Utilidades.Arreglo(arreglo, 4);
            Imprimir.imprimirCalculo(arreglo, resultado, sw);

        }

        public static void mediana(double[,] matriz, StreamWriter sw)
        {
            double[] arreglo = ConvertirMatrizArreglo(matriz);
            Array.Sort(arreglo);
            double[] valores = new double[2] { arreglo.Length, 2 };
            double resultado = Utilidades.Arreglo(valores, 4);
            Imprimir.imprimirCalculo(arreglo, resultado, sw);

        }

        public static void moda(double[,] matriz, StreamWriter sw)
        {
            double[] arreglo = ConvertirMatrizArreglo(matriz);

            double maxNumero = arreglo[0];
            int maxVeces = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                int numVeces = 0;
                for (int j = 0; j < arreglo.Length; j++)
                { if (arreglo[j] == arreglo[i]) { numVeces++; } }

                if (numVeces > maxVeces)
                {
                    maxNumero = arreglo[i];
                    maxVeces = numVeces;
                }
            }
            double resultado = maxNumero;
            Imprimir.imprimirCalculo(arreglo, resultado, sw);

        }

        private static double[] ConvertirMatrizArreglo(double[,] matriz)
        {
            double[] arreglo = new double[matriz.Length];

            int i = 0;
            foreach (double numero in matriz)
            {
                arreglo[i] = numero;
                i++;
            }
            return arreglo;
        }
    }
}
