namespace BlackJack
{
    internal class Juego
    {
        private List<Jugador> jugadores { get; set; }
        private Baraja cartas { get; set; }

        public Juego(List<string> nombresJugadores)
        {
            if (nombresJugadores.Count > 7)
            {
                throw new ArgumentException("El máximo número de jugadores es 7.");
            }

            jugadores = new List<Jugador>();
            foreach (var nombre in nombresJugadores)
            {
                jugadores.Add(new Jugador(nombre));
            }

            cartas = new Baraja();
            cartas.Barajar();
        }

        public void Iniciar()
        {
            Console.WriteLine("Repartiendo cartas...");
            cartas.Repartir(jugadores);

            foreach (var jugador in jugadores)
            {
                Console.WriteLine(jugador);
            }
        }
    }
}
