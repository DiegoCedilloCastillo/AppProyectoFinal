using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AppProyectoFinal
{
    public static class Utilidades
    {
        public static double Arreglo(double[] arreglo, int opcion)
        {
            if (arreglo[0] == 0 && arreglo[1] == 0)
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    Console.WriteLine("Escriba un valor: ");
                    arreglo[i] = int.Parse(Console.ReadLine());
                }
            }
            double resultado = 0;
            if (opcion == 1) { OperacionesBasicas ob = new OperacionesBasicas(); resultado = ob.suma(arreglo); }
            if (opcion == 2) { OperacionesBasicas ob = new OperacionesBasicas(); resultado = ob.resta(arreglo); }
            if (opcion == 3) { OperacionesBasicas ob = new OperacionesBasicas(); resultado = ob.multiplicacion(arreglo); }
            if (opcion == 4) { OperacionesBasicas ob = new OperacionesBasicas(); resultado = ob.division(arreglo); }
            return resultado;
        }
    }
}