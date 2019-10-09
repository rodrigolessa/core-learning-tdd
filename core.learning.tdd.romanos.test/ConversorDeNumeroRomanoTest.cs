using NUnit.Framework;
using core.learning.tdd.romanos;

namespace Tests
{
    // [SetUpFixture] // SetUpFixture faz com que o Setup e o TearDown execute uma vez
    [TestFixture]
    public class ConversorDeNumeroRomanoTest
    {
        // Converter números romanos em numeral Arábico

        // TODO: Os números eram representados por sete diferentes símbolos.

        // | I | unus         | 1 (um)           |
        // | V | quinque      | 5 (cinco)        |
        // | X | decem        | 10 (dez)         |
        // | L | quinquaginta | 50 (cinquenta)   |
        // | C | centum       | 100 (cem)        |
        // | D | quingenti    | 500 (quinhentos) |
        // | M | mille        | 1.000 (mil)      |

        // Regras
        // TODO: Algarismos de menor ou igual valor à direita são somados ao algarismo de maior valor.
        // TODO: Algarismos de menor valor à esquerda são subtraídos do algarismo de maior valor.
        // Exemplo:   XV representa 15 (10 + 5) 
        // e o número XXVIII representa 28 (10 + 10 + 5 + 1 + 1 + 1). 
        // e o número IX representa 9 (10 - 1). 
        // TODO: Nenhum símbolo pode ser repetido lado a lado por mais de 3 vezes.
        // Exemplo: o número 4 é representado pelo número IV (5 - 1) e não pelo número IIII.

        //[OneTimeSetUp]
        //public void RunBeforeAnyTests()
        [SetUp]
        public void Setup()
        {
        }

        //[TearDown]
        //public void RunAfterAnyTests() { }

        #region Primeiro Cenário - Representação dos Algarismos.

        [Test] // , Category("Representação")]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("I");

            Assert.AreEqual(1, numero);
        }

        [Test, Category("Representação")]
        public void DeveEntenderOSimboloV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("V");

            Assert.AreEqual(5, numero);
        }

        [Test, Category("Representação")]
        public void DeveEntenderOSimboloX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("X");

            Assert.AreEqual(10, numero);
        }

        [Test, Category("Representação")]
        public void DeveEntenderOSimboloL()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("L");

            Assert.AreEqual(50, numero);
        }

        [Test, Category("Representação")]
        public void DeveEntenderOSimboloC()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("C");

            Assert.AreEqual(100, numero);
        }

        [Test, Category("Representação")]
        public void DeveEntenderOSimboloD()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("D");

            Assert.AreEqual(500, numero);
        }

        [Test, Category("Representação")]
        public void DeveEntenderOSimboloM()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("M");

            Assert.AreEqual(1000, numero);
        }

        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        public void DeveEntenderOsSimbolos(string simbolo, int valor)
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte(simbolo);

            Assert.AreEqual(valor, numero);
        }

        #endregion

        #region Segundo Cenário - Dois símbolos em sequência.

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("II");

            Assert.AreEqual(2, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoVI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("VI");

            Assert.AreEqual(6, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoXI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XI");

            Assert.AreEqual(11, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoXX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XX");

            Assert.AreEqual(20, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoLI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("LI");

            Assert.AreEqual(51, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoLV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("LV");

            Assert.AreEqual(55, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoLX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("LX");

            Assert.AreEqual(60, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoCI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("CI");

            Assert.AreEqual(101, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoCX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("CX");

            Assert.AreEqual(110, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoDX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("DX");

            Assert.AreEqual(510, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoDC()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("DC");

            Assert.AreEqual(600, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoMX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("MX");

            Assert.AreEqual(1010, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderDoisSimbolosComoMD()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("MD");

            Assert.AreEqual(1500, numero);
        }

        #endregion

        #region Terceiro Cenário - Mais de dois símbolos em sequência.

        [Test, Category("Adição")]
        public void DeveEntenderMaisSimbolosComoIII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("III");

            Assert.AreEqual(3, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderMaisSimbolosComoXXII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XXII");

            Assert.AreEqual(22, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderMaisSimbolosComoMDX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("MDX");

            Assert.AreEqual(1510, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderMaisSimbolosComoMDXV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("MDXV");

            Assert.AreEqual(1515, numero);
        }

        [Test, Category("Adição")]
        public void DeveEntenderMaisSimbolosComoDCLXII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("DCLXII");

            Assert.AreEqual(662, numero);
        }

        #endregion

        #region Quarto Cenário - Símbolos em sequência e/ou invertidos.

        [Test, Category("Subtração")]
        public void DeveEntenderSimbolosInvertidosComoIV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("IV");

            Assert.AreEqual(4, numero);
        }

        [Test, Category("Subtração")]
        public void DeveEntenderSimbolosInvertidosComoXXIV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("XXIV");

            Assert.AreEqual(24, numero);
        }

        [Test, Category("Subtração")]
        public void DeveEntenderSimbolosInvertidosComoDXLIIX()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("DXLIIX");

            Assert.AreEqual(548, numero);
        }

        #endregion

        #region Quinto Cenário - Testes que devem falhar - Símbolos com sequência incorreta.

        [Test, Category("Falha")]
        public void DeveFalharComQuatroSimbolosIguaisIIII()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("IIII");

            Assert.AreEqual(0, numero);
        }

        [Test, Category("Falha")]
        public void DeveFalharComQuatroSimbolosIguaisVVVV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("VVVV");

            Assert.AreEqual(0, numero);
        }

        #endregion
    }
}