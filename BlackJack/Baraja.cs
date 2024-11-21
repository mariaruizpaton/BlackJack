using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Baraja
    {
        private List<Carta> cartas { get; set; }
        private int posicionActual { get; set; }

        public Baraja()
        {
            string[] BarajaArray = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            char[] PalosArray = { 'T', 'D', 'C', 'P' };

            cartas = new List<Carta>();
            foreach (var palo in PalosArray)
            {
                foreach (var numero in BarajaArray)
                {
                    cartas.Add(new Carta(numero, palo));
                }
            }
            posicionActual = 0;
        }

        public void Barajar()
        {
            Random rand = new Random();
            for (int i = 0; i < cartas.Count; i++)
            {
                int indexRandom = rand.Next(cartas.Count);
                (cartas[i], cartas[indexRandom]) = (cartas[indexRandom], cartas[i]);
            }
            posicionActual = 0;
        }

        public Carta DarCarta()
        {
            int posicion = posicionActual;
            posicionActual++;
            return cartas[posicion];
        }

        public void Repartir(List<Jugador> jugadores)
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (var jugador in jugadores)
                {
                    jugador.PedirCarta(DarCarta());
                }
            }
        }
    }
}
