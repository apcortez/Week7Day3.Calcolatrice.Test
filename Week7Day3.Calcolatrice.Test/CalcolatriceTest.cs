using System;
using Wee7Day3.Calcolatrice.Core;
using Xunit;

namespace Week7Day3.Calcolatrice.Test
{
    public class CalcolatriceTest
    {
        [Fact]
        public void TestCaseAddizione()
        {
            //Arrange: predisposizione test
            Calculator calcolatrice = new Calculator();

            //ACT: chiedi funzionalità da testare
            decimal? risultato = calcolatrice.Somma(10, 33);

            //ASSERT: verifica del risultato
            Assert.True(risultato == 43);
        }
        [Fact]
        public void TestCaseSottrazione()
        {
            //Arrange: predisposizione test
            Calculator calcolatrice = new Calculator();

            //ACT: chiedi funzionalità da testare
            decimal? risultato = calcolatrice.Sottrai(10.50m, 1);

            //ASSERT: verifica del risultato
            Assert.True(risultato == 9.50m);
        }
        [Fact]
        public void TestCaseMoliplicazione()
        {
            //Arrange: predisposizione test
            Calculator calcolatrice = new Calculator();

            //ACT: chiedi funzionalità da testare
            decimal? risultato = calcolatrice.Moltiplica(10, 33);

            //ASSERT: verifica del risultato
            Assert.True(risultato == 330);
        }
        [Fact]
        public void TestCaseDivisone1()
        {
            //Arrange: predisposizione test
            Calculator calcolatrice = new Calculator();

            //ACT: chiedi funzionalità da testare
            decimal? risultato = calcolatrice.Dividi(150, 3);

            //ASSERT: verifica del risultato
            Assert.True(risultato == 50);
        }
        [Fact]
        public void TestCaseDivisione2()
        {
            //Arrange: predisposizione test
            Calculator calcolatrice = new Calculator();

            //ACT: chiedi funzionalità da testare
            decimal? risultato = calcolatrice.Dividi(45, 0);

            //ASSERT: verifica del risultato
            Assert.True(risultato==null);
        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB()
        {
            //ARRANGE: predisposizione del test
            Calculator calcolatrice = new Calculator(); //modificate il nome della classe in base a quella che avete voi nel Core
                                                        //ACT: chiamata alla funzionalità da testare
            bool risultato = calcolatrice.VerificaSeAMaggioreDiB(3, 1);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB2()
        {
            //ARRANGE: predisposizione del test
            Calculator calcolatrice = new Calculator(); //modificate il nome della classe in base a quella che avete voi nel Core
                                                        //ACT: chiamata alla funzionalità da testare
            bool risultato = calcolatrice.VerificaSeAMaggioreDiB(3.2m, 3.2m);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }
    }
}
