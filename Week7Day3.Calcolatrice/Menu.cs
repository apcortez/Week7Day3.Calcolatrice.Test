using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wee7Day3.Calcolatrice.Core;

namespace Week7Day3.Calcolatrice
{
    class Menu
    {
        internal static void Start()
        {
            bool continuare = true;
            Console.WriteLine("################# BENVENUTO! ################");
            do
            {
                Console.WriteLine("Inserisci 1^ numero:");
                double a = InserisciNumero();
                Console.WriteLine("Inserisci 2^ numero:");
                double b = InserisciNumero();
                Console.WriteLine();
                Console.WriteLine("#############################################");
                Console.WriteLine("Selezionare un operazione da eseguire:");
                Console.WriteLine("1 - Addizione");
                Console.WriteLine("2 - Sottrazione");
                Console.WriteLine("3 - Multiplicazione");
                Console.WriteLine("4 - Divisione");
                Console.WriteLine("5 - Confronta se il primo numero è maggiore del secondo");
                Console.WriteLine("0 - Per uscire");
                Console.WriteLine("#############################################");
               
                Calculator calcolatrice = new Calculator();

                Console.WriteLine();
                Console.WriteLine("Quale operazione vuoi scegliere?");
                string scelta = Console.ReadLine();
                double? risultato = 0; bool confronto= true;
                switch (scelta)
                {
                    case "1":
                        risultato = calcolatrice.Somma(a, b);
                        break;
                    case "2":
                        risultato = calcolatrice.Sottrai(a, b);
                        break;
                    case "3":
                        risultato = calcolatrice.Moltiplica(a, b);
                        break;
                    case "4":
                        risultato = calcolatrice.Dividi(a, b);
                        break;
                    case "5":
                         confronto = calcolatrice.VerificaSeAMaggioreDiB(a, b);
                        break;
                    case "0":
                        Console.WriteLine("Arrivederci. A presto!");
                        continuare = false;
                        break;
                    default:
                        Console.WriteLine("Scelta sbagliata riprova");
                        break;
                }
                if (risultato ==null)
                { break; }
                else
                {
                    Console.WriteLine($"Il risultato è {risultato}");
                }
                    if (!confronto)
                    {
                        Console.WriteLine("Il primo numero è minore del secondo numero.");
                    }
                    else
                    {
                        Console.WriteLine("Il primo numero è maggiore del secondo numero.");
                    }

            } while (continuare);
        }


        private static double InserisciNumero()
        {
            bool isdouble;
            double numero;
            do
            {
                isdouble = double.TryParse(Console.ReadLine(), out numero);

            } while (!isdouble);

            return numero;
        }

    }
}
