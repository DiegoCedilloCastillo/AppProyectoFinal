using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProyectoFinal
{
    public class ConversionesDistancias : ObjetosPrincipales
    {
        public static void metodoDistancias(StreamWriter sw, int opcion)
        {
            ConversionesDistancias distancia = new ConversionesDistancias();
            Console.WriteLine("Ingresa la distancia a convertir:");
            double valor = double.Parse(Console.ReadLine());
            distancia.Valor1 = valor;

            switch (opcion)
            {
                case 1: { distancia.OpMetrosKilometros(sw, distancia.valor1); } break;
                case 2: { distancia.OpKilometrosMetros(sw, distancia.valor1); } break;
                case 3: { distancia.OpKilometrosCentimetros(sw, distancia.valor1); } break;
                case 4: { distancia.OpKilometrosMillas(sw, distancia.valor1); } break;
                case 5: { distancia.OpMillasMetros(sw, distancia.valor1); } break;
                case 6: { distancia.OpMillasKilometros(sw, distancia.valor1); } break;
                case 7: { distancia.OpPulgadasCentimetros(sw, distancia.valor1); } break;
                case 8: { distancia.OpCentimetrosPulgadas(sw, distancia.valor1); } break;
                case 9: { distancia.OpMilimetrosCentimetros(sw, distancia.valor1); } break;
                case 10: { distancia.OpMilimetrosMetros(sw, distancia.valor1); } break;
                case 11: { distancia.OpMilimetrosPulgadas(sw, distancia.valor1); } break;

            }
        }

        public void OpMetrosKilometros(StreamWriter sw, double valor) //Metros a Kilómetros
        {
            double[] valores = new double[2] { valor, 1000 };
            resultado = Utilidades.Arreglo(valores, 4);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Metros en Kilometros es de: ");
        }


        public void OpKilometrosMetros(StreamWriter sw, double valor) //Kilómetros a Metros
        {
            double[] valores = new double[2] { valor, 1000 };
            resultado = Utilidades.Arreglo(valores, 3);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Kilometros en Metros es de: ");
        }


        public void OpKilometrosCentimetros(StreamWriter sw, double valor) //Kilómetros a Centímetros
        {
            double[] valores = new double[2] { valor, 100000 };
            resultado = Utilidades.Arreglo(valores, 3);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Kilometros en Centimetros es de: ");
        }


        public void OpKilometrosMillas(StreamWriter sw, double valor) //Kilómetros a Millas
        {
            double[] valores = new double[2] { valor, 1.609 };
            resultado = Utilidades.Arreglo(valores, 4);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Kilometros en Millas es de: ");
        }


        public void OpMillasMetros(StreamWriter sw, double valor) //Millas a Metros
        {
            double[] valores = new double[2] { valor, 1.609 };
            resultado = Utilidades.Arreglo(valores, 3);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Millas en Metros es de: ");
        }


        public void OpMillasKilometros(StreamWriter sw, double valor) //Millas a Kilómetros
        {
            double[] valores = new double[2] { valor, 1.609 };
            resultado = Utilidades.Arreglo(valores, 3);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Millas en Kilometros es de: ");
        }


        public void OpPulgadasCentimetros(StreamWriter sw, double valor) //Pulgadas a Centímetros
        {
            double[] valores = new double[2] { valor, 2.54 };
            resultado = Utilidades.Arreglo(valores, 3);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Pulgadas en Centimetros es de: ");
        }


        public void OpCentimetrosPulgadas(StreamWriter sw, double valor) //Centímetros a Pulgadas
        {
            double[] valores = new double[2] { valor, 2.54 };
            resultado = Utilidades.Arreglo(valores, 4);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Centimetros en Pulgadas es de: ");
        }


        public void OpMilimetrosCentimetros(StreamWriter sw, double valor)  //Milímetros a Centímetros
        {
            double[] valores = new double[2] { valor, 10 };
            resultado = Utilidades.Arreglo(valores, 4);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Milimetros en Centietros es de: ");
        }


        public void OpMilimetrosMetros(StreamWriter sw, double valor)  //Milimetros a Metros
        {
            double[] valores = new double[2] { valor, 1000 };
            resultado = Utilidades.Arreglo(valores, 4);
            Imprimir.imprimirConversiones(sw, valor, resultado, " Milimetros en Metros es de: ");
        }


        public void OpMilimetrosPulgadas(StreamWriter sw, double valor)  //Milimetros a Pulgadas
        {
            double[] valores = new double[2] { valor, 25.4 };
            resultado = Utilidades.Arreglo(valores, 4);

            Imprimir.imprimirConversiones(sw, valor, resultado, " Milimetros en Pulgadas es de: ");
        }
    }
}
