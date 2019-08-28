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

            for (int i = 0; i < numeroEmRomano.Length; i++)
                valor += mapaDeAlgarismo[numeroEmRomano[i].ToString()];

            return valor;
        }
    }
}
