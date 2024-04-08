using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador(100, 20);
            List<Enemigo> enemigos = new List<Enemigo>
            {
                new EnemigoMelee(50, 15),
                new EnemigoRango(40, 10, 3),
                new EnemigoMelee(60, 12)
            };

            Juego juego = new Juego(jugador, enemigos);
            juego.ControlarJuego();
        }
    }
}
