using System;
using System.IO;
using System.Diagnostics;

namespace AppProyectoFinal
{
    class Program
    {
        static string path = @"textoEjemplo.txt";
        static StreamWriter sw = new StreamWriter(path);

        static void Main(string[] args) //MENÚ PRINCIPAL
        {
            bool end = false;
            while (!end)
            {
                Console.Clear();

                Console.WriteLine("Bienvenido. \n\r");
                Console.WriteLine("Por favor, selecciona el Nodo con el que quieres trabajar. \n\r");
                Console.WriteLine("1. Operaciones Básicas \n\r");
                Console.WriteLine("2. Cálculo de Áreas \n\r");
                Console.WriteLine("3. Cálculos Variados (Promedio, mediana, etc). \n\r");
                Console.WriteLine("4. Conversión de Temperaturas \n\r");
                Console.WriteLine("5. Conversión de Distancias \n\r");
                Console.WriteLine("6. Índice de Masa Corporal \n\r");
                int nodo = int.Parse(Console.ReadLine());

                switch (nodo)
                {
                    case 1: //OPERACIONES BÁSICAS
                        {
                            Console.Clear();
                            Console.WriteLine("Has elegido el nodo de las Operaciones Básicas, ¿Qué quieres hacer?");
                            Console.WriteLine("1) Suma                 2) Resta");
                            Console.WriteLine("3) Multiplicación       4) División");
                            int nodo1 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            OperacionesBasicas.metodoOperacionesBasicas(sw, nodo1);
                            Console.WriteLine("Desea continuar? [S/N] ...");
                            if (Console.ReadLine().ToLower() == "n")
                            { Console.Clear(); end = true; continue; }
                        }
                        break;

                    case 2: //AREAS DE FIGURAS GEOMÉTRICAS
                        {
                            Console.Clear();
                            Console.WriteLine("Has elegido el nodo del Cálculo de Áreas, ¿Qué quieres hacer?");
                            Console.WriteLine("1) Area de un Triangulo     2) Area de un Rectángulo");
                            Console.WriteLine("3) Area de un Circulo       4) Area de un Cuadrado");
                            int nodo2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (nodo2)
                            {
                                case 1: //TRIANGULO
                                    { FigurasGeometricas triangulo = new FigurasGeometricas(); triangulo.AreaTriangulo(sw); }
                                    break;

                                case 2: //RECTANGULO
                                    { FigurasGeometricas rectangulo = new FigurasGeometricas(); rectangulo.AreaRectangulo(sw); }
                                    break;

                                case 3: //CIRCULO
                                    { FigurasGeometricas circulo = new FigurasGeometricas(); circulo.AreaCirculo(sw); }
                                    break;

                                case 4: //CUADRADO
                                    { FigurasGeometricas cuadrado = new FigurasGeometricas(); cuadrado.AreaCuadrado(sw); }
                                    break;
                            }
                            Console.WriteLine("Desea continuar? [S/N] ...");
                            if (Console.ReadLine().ToLower() == "n")
                            { Console.Clear(); end = true; continue; }
                        }
                        break;

                    case 3: //CÁLCULOS VARIADOS
                        {
                            Console.Clear();
                            Console.WriteLine("Has elegido el nodo de los Cálculos Variados, ¿Qué quieres hacer?");
                            Console.WriteLine("1) Promedio     2) Desviación Estándar");
                            Console.WriteLine("3) Mediana      4) Moda");
                            int nodo3 = int.Parse(Console.ReadLine());
                            CalculosVariados.calculo(sw, nodo3);
                            Console.WriteLine("Desea continuar? [S/N] ...");
                            if (Console.ReadLine().ToLower() == "n")
                            { Console.Clear(); end = true; continue; }
                        }
                        break;

                    case 4: //CONVERSIONES DE TEMPERATURAS
                        {
                            Console.Clear();
                            Console.WriteLine("Has elegido el nodo de la Conversión de Temperaturas, ¿Qué quieres hacer?");
                            Console.WriteLine("1) Centígrados a Fahrenheit          2) Fahrenheit a Centígrados");
                            Console.WriteLine("3) Fahrenheit a Kelvin               4) Kelvin a Fahrenheit");
                            int nodo4 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            ConversionesTemperatura.metodoTemperaturas(sw, nodo4);
                            Console.WriteLine("Desea continuar? [S/N] ...");
                            if (Console.ReadLine().ToLower() == "n")
                            { Console.Clear(); end = true; continue; }
                        }
                        break;

                    case 5: //CONVERSIONES DE DISTANCIAS
                        {
                            Console.Clear();
                            Console.WriteLine("Has elegido el nodo de la Conversión de Distancias, ¿Qué quieres hacer?");
                            Console.WriteLine("1) Metros a Kilómetros          2) Kilómetros a Metros");
                            Console.WriteLine("3) Kilómetros a Centímetros     4) Kilómetros a Millas");
                            Console.WriteLine("5) Millas a Metros              6) Millas a Kilómetros");
                            Console.WriteLine("7) Pulgadas a Centímetros       8) Centímetros a Pulgadas");
                            Console.WriteLine("9) Milímetros a Centímetros     10) Milímetros a Metros");
                            Console.WriteLine("11) Milímetros a Pulgadas");
                            int nodo5 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            ConversionesDistancias.metodoDistancias(sw, nodo5);
                            Console.WriteLine("Desea continuar? [S/N] ...");
                            if (Console.ReadLine().ToLower() == "n")
                            { Console.Clear(); end = true; continue; }
                        }
                        break;

                    case 6: //ÍNDICE DE MASA CORPORAL
                        {
                            Console.Clear();
                            Console.WriteLine("Has elegido el nodo del Índice de Masa Corporal.");
                            IndiceMasaCorporal imc = new IndiceMasaCorporal();
                            imc.IndiceMC(sw);

                            Console.WriteLine("Desea continuar? [S/N] ...");
                            if (Console.ReadLine().ToLower() == "n")
                            { Console.Clear(); end = true; continue; }
                        }
                        break;
                }
            }
            sw.Close();
            Process.Start(path);
        }
    }
}