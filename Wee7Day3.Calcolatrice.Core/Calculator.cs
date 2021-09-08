using System;

namespace Wee7Day3.Calcolatrice.Core
{
    public class Calculator
    {
        decimal? risultato;
        public decimal? Somma(decimal a, decimal b)
        {
            risultato = a + b;
            return risultato;
        }

        public decimal? Sottrai(decimal a, decimal b)
        {
            risultato = a - b;
            return risultato;
        }

        public decimal? Moltiplica(decimal a, decimal b)
        {
            risultato = a * b;
            return risultato;
        }

        public decimal? Dividi(decimal a, decimal b)
        {
            try
            {
                risultato = a / b;
                
            }catch(DivideByZeroException e) { Console.WriteLine("Errore: divisione per zero"); risultato = null; }
            return risultato;
        }

        public bool VerificaSeAMaggioreDiB(decimal a, decimal b)
        {
            if (a >= b)
            {
                return true;
            }
            else return false;
        }
    }
}
