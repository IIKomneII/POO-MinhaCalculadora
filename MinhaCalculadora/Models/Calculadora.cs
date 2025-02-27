using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCalculadora.Models
{
    internal class Calculadora
    {
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            for (int i = 0; i < numero2; i++)
            {
                return numero1 += numero1;
            }
            
        }

        public int Dividir(int numero1, int numero2)
        {
            try
            {
                return numero1 / numero2;
            }
            catch (DivideByZeroException)
            {
                return -1;
            }
        }
    }
}
