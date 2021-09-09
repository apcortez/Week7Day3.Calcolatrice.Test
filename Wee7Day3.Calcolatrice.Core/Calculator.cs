using System;

namespace Wee7Day3.Calcolatrice.Core
{
    public class Calculator
    {
        double? risultato;
        public double? Somma(double a, double b)
        {
            risultato = a + b;
            return risultato;
        }

        public double? Sottrai(double a, double b)
        {
            risultato = a - b;
            return risultato;
        }

        public double? Moltiplica(double a, double b)
        {
            risultato = a * b;
            return risultato;
        }

        /// <summary>
        /// Ritorna un errore in caso ci sia la divisione per zero.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double? Dividi(double a, double b)
        {
            try
            {
                risultato = a / b;
                
            }catch(DivideByZeroException e) { risultato = null; }
            return risultato;
        }

        public bool VerificaSeAMaggioreDiB(double a, double b)
        {
            if (a >= b)
            {
                return true;
            }
            else return false;
        }
    }
}
