using NUnit.Framework;
using core.learning.tdd.contencioso.Services;

namespace Tests
{
    public class ValidadorDeNumeroCNJTest
    {
        // O número é formado por X conjuntos de dígitos assim distribuídos:
        // NNNNNNN-DD.AAAA.J.TR.OOOO

        // NNNNNNN - 7 dígitos que indicam o número de ordem de autuação do processo, no ano de autuação e na unidade jurisdicional de origem;
        // DD - 2 dígitos verificadores da integridade do número, calculados a partir de todos os demais dígitos;
        // AAAA - 4 dígitos indicadores do ano da autuação;
        // J - 1 dígito identificador do segmento do Judiciário a que pertence o processo:
            // - 1 para o Supremo Tribunal Federal, 
            // - 2 para o Conselho Nacional de Justiça, 
            // - 3 para o Superior Tribunal de Justiça, 
            // - 4 para a Justiça Federal, 
            // - 5 para a Justiça do Trabalho, 
            // - 6 para a Justiça Eleitoral, 
            // - 7 para a Justiça Militar da União, 
            // - 8 para a Justiça dos Estados e do Distrito Federal e Territórios,
            // - 9 para a Justiça Militar Estadual;
        // TR - 2 dígitos que identificam o tribunal ou conselho do segmento do Poder Judiciário a que pertence o processo;
        // OOOO - 4 dígitos identificadores da unidade de origem do processo.

        private ValidadorDeNumeroCNJ validadorDeNumeroCNJ;

        [SetUp]
        public void Setup()
        {
            validadorDeNumeroCNJ = new ValidadorDeNumeroCNJ();
        }

        [Test]
        public void ReconhecerProcessoValidoNoTribunalTRTRJ()
        {
            Assert.IsTrue(validadorDeNumeroCNJ.Validar("0033739-92.1999.8.26.0100"));
        }

        [Test]
        public void ReconhecerProcessoValidoNoTribunalTJMT()
        {
            Assert.IsTrue(validadorDeNumeroCNJ.Validar("1016768-15.1999.8.26.0100"));
        }

        [Test]
        public void ReconhecerProcessoValidoNoTribunalTRTPR()
        {
            Assert.IsTrue(validadorDeNumeroCNJ.Validar("5006601-96.2012.4.04.7200"));
        }

        [Test]
        public void ValidarNumeracaoUnica()
        {
            var processos = ObterNumerosDeProcessosValidos();
            foreach (string processo in processos)
                Assert.IsTrue(validadorDeNumeroCNJ.Validar(processo));
        }

        public List<string> ObterNumerosDeProcessosValidos()
        {
            return System.IO.File.ReadAllLines("processos.txt").ToList();
        }
    }
}