using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProyectoFinal
{
    public abstract class ObjetosPrincipales
    {
        public double valor1, valor2, resultado;
        public ObjetosPrincipales()
        {
            valor1 = valor2 = resultado = 0;
        }
        public double Valor1
        {
            get { return valor1; }
            set { valor1 = value; }
        }
        public double Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }
        public double Resultado
        {
            get { return resultado; }
        }
    }
}