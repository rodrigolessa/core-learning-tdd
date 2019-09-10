using System;

namespace core.learning.tdd.contencioso.Services
{
    public class ValidadorDeNumeroCNJ
    {
    	public bool Validar(string numeroDoProcesso)
    	{
            if (string.IsNullOrEmpty(numeroDoProcesso))
                throw new Exception("Informa o número do processo");
            
            if (numeroDoProcesso.Length < 20)
                throw new Exception("Informa um número válido");

			// TODO: Melhorar nome da variável para mais amigável. Referência para Clean Code.
            string n = Regex.Replace(args[0], "[^0-9]", "");

            if (n.Length != 20)
                throw new Exception("Número inválido");

            var processo = new Tuple<string, string, string, string, string, string>(
                n.Substring(0, 7),  // Sequencial
                n.Substring(7, 2),  // Digito verificador
                n.Substring(9, 4),  // Ano do ajuizamento
                n.Substring(13, 1), // Segmento do judiciário
                n.Substring(14, 2), // Tribunal
                n.Substring(16, 4)  // Unidade de origem
            );

            UInt64.TryParse(processo.Item1, out UInt64 p1);

// TODO: Melhorar nome da variável para mais amigável. Referência para Clean Code
            string resto1 = (p1 % 97).ToString();

            UInt64.TryParse($"{resto1}{processo.Item3}{processo.Item4}{processo.Item5}", out UInt64 p2);

// TODO: Melhorar nome da variável para mais amigável. Referência para Clean Code
            string resto2 = (p2 % 97).ToString();

// TODO: Melhorar nome da variável para mais amigável. Referência para Clean Code
            string c = $"{resto2}{processo.Item6}00";
            
// TODO: Melhorar nome da variável para mais amigável. Referência para Clean Code
            UInt64.TryParse(c, out UInt64 s);
            UInt64.TryParse(processo.Item2, out UInt64 d);

// TODO: Melhorar nome da variável para mais amigável. Referência para Clean Code
            var r = 98 - (s % 97);

            if (d == r)
                return true;
    	}
    }
}