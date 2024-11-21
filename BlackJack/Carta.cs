using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    
    internal class Carta
    {
        public string Numero { get; set; }
        public char Palo { get; set; }

        public Carta(string num, char palo) 
        { 
            Numero = num;
            Palo = palo;
        }

        public int ValorEntero()
        {
            if (Numero == "A") return 1;
            if (Numero == "J" || Numero == "Q" || Numero == "K") return 10;
            return int.Parse(Numero);
        }
    }
}
