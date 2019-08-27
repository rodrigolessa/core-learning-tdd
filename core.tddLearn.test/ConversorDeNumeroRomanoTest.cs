using NUnit.Framework;
using core.tddLearn.domain;

namespace Tests
{
    [TestFixture]
    public class ConversorDeNumeroRomanoTest
    {
        // O problema dos números romanos

        // Os números eram representados por sete diferentes símbolos:

        // I, unus = 1 (um) 
        // V, quinque = 5 (cinco) 
        // X, decem = 10 (dez) 
        // L, quinquaginta = 50 (cinquenta) 
        // C, centum = 100 (cem) 
        // D, quingenti = 500 (quinhentos) 
        // M, mille = 1.000 (mil)

        // Regras
        // * Algarismos de menor ou igual valor à direita são somados ao algarismo de maior valor.
        // * Algarismos de menor valor à esquerda são subtraídos do algarismo de maior valor.
        // Exemplo:   XV representa 15 (10 + 5) 
        // e o número XXVIII representa 28 (10 + 10 + 5 + 1 + 1 + 1). 
        // * Nenhum símbolo pode ser repetido lado a lado por mais de 3 vezes. 
        // Exemplo: o número 4 é representado pelo número IV (5 - 1) e não pelo número IIII.

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("I");

            Assert.AreEqual(1, numero);
        }
    }
}