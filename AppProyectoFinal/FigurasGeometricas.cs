using System;
using System.IO;

namespace AppProyectoFinal
{
    public class FigurasGeometricas : ObjetosPrincipales
    {
        public void AreaTriangulo(StreamWriter sw) //Triangulo
        {
            FigurasGeometricas triangulo = new FigurasGeometricas();
            Console.WriteLine("Ingresa la base del Triangulo:");
            triangulo.Valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la altura del Triangulo:");
            triangulo.Valor2 = double.Parse(Console.ReadLine());

            double[] valores = new double[3] { triangulo.valor1, triangulo.valor2, 0.5 };
            triangulo.resultado = Utilidades.Arreglo(valores, 3);

            Imprimir.imprimirTriangulo(sw, triangulo.Valor1, triangulo.Valor2, triangulo.resultado);
        }


        public void AreaRectangulo(StreamWriter sw) //Rectángulo
        {
            FigurasGeometricas rectangulo = new FigurasGeometricas();
            Console.WriteLine("Ingresa la base del Rectangulo:");
            rectangulo.Valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la altura del Rectangulo:");
            rectangulo.Valor2 = double.Parse(Console.ReadLine());

            double[] valores = new double[2] { rectangulo.valor1, rectangulo.valor2 };
            rectangulo.resultado = Utilidades.Arreglo(valores, 3);

            Imprimir.imprimirRectangulo(sw, rectangulo.valor2, rectangulo.valor2, rectangulo.resultado);
        }


        public void AreaCirculo(StreamWriter sw) //Circulo
        {
            FigurasGeometricas circulo = new FigurasGeometricas();
            Console.WriteLine("Ingresa el radio del Circulo:");
            circulo.Valor1 = double.Parse(Console.ReadLine());

            double[] valores = new double[2] { Math.PI, Math.Pow(circulo.valor1, 2) };
            circulo.resultado = Utilidades.Arreglo(valores, 3);

            Imprimir.imprimirCirculo(sw, circulo.valor1, circulo.resultado);
        }


        public void AreaCuadrado(StreamWriter sw) //Cuadrado
        {
            FigurasGeometricas cuadrado = new FigurasGeometricas();
            Console.WriteLine("Ingresa el lado del Cuadrado:");
            cuadrado.Valor1 = double.Parse(Console.ReadLine());

            double[] valores = new double[2] { cuadrado.Valor1, cuadrado.valor1 };
            cuadrado.resultado = Utilidades.Arreglo(valores, 3);

            Imprimir.imprimirCirculo(sw, cuadrado.valor1, cuadrado.resultado);
        }
    }
}
