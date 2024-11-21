namespace BlackJack
{
    internal class Juego
    {
        private int[] jugadores { get; set; }
        private Baraja cartas { get; set; }

        public Juego()
        {
            jugadores = new int[7];
        }
    }
}
