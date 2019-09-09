using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace core.tddLearn.domain
{
    public class ConversorDeNumeroRomano
    {
        private Dictionary<string, int> mapaDeAlgarismo = new Dictionary<string, int>(){
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000}
        };

        public int Converte(string numeroEmRomano)
        {
            int valor = 0;
            int anterior = 0;
            string ultimo = string.Empty;
            int repetidos = 0;

            for (int i = 0; i < numeroEmRomano.Length; i++)
            {
                if (ultimo == numeroEmRomano[i].ToString())
                {
                    repetidos++;
                    if (repetidos > 2)
                        return 0;
                }
                else
                    repetidos = 0;

                ultimo = numeroEmRomano[i].ToString();
            }

            for (int i = numeroEmRomano.Length - 1; i >= 0; i--)
            {
                int arabico = mapaDeAlgarismo[numeroEmRomano[i].ToString()];
                if (arabico < anterior)
                    arabico *= -1;
                else
                    anterior = arabico;

                valor += arabico;
            }

            return valor;
        }
    }
}
