using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Jugador
    {
        private string Nombre { get; set; }
        private List<Carta> Mano { get; set; }

        public Jugador(string Nombre)
        {
            this.Nombre = Nombre;
            Mano = new List<Carta>();
        }

        public void PedirCarta(Carta carta)
        {
            this.Mano.Add(carta);
        }

        public int ContarMano()
        {
            int ases = 0;
            int total = 0;

            foreach (Carta carta in Mano)
            {
                int valor = carta.ValorEntero();
                total += valor;
                if (valor == 1)
                {
                    ases++;
                }
            }

            while (ases > 0 && total + 10 <= 21)
            {
                total += 10;
                ases--;
            }
            return total;
        }
    }
}
