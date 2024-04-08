using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_tarea
{
    internal class Juego
    {
        private Jugador jugador;
        private List<Enemigo> enemigos;

        public Juego(Jugador jugador, List<Enemigo> enemigos)
        {
            this.jugador = jugador;
            this.enemigos = enemigos;
        }

        public void ControlarJuego()
        {
            int turno = 0;
            while (jugador.Vida > 0 && enemigos.Any(e => e.EstaVivo()))
            {
                Console.WriteLine($"\nTurno {turno + 1}");
                var enemigo = enemigos.FirstOrDefault(e => e.EstaVivo());

                if (enemigo != null)
                {
                    Console.WriteLine($"Jugador ataca al enemigo causando {jugador.ObtenerDaño()} de daño.");
                    enemigo.RecibirDaño(jugador.ObtenerDaño());
                    if (!enemigo.EstaVivo())
                    {
                        Console.WriteLine("El enemigo ha sido derrotado.");
                    }
                }

                enemigo = enemigos.FirstOrDefault(e => e.EstaVivo());
                if (enemigo != null)
                {
                    Console.WriteLine($"Enemigo ataca al jugador causando {enemigo.ObtenerDaño()} de daño.");
                    jugador.RecibirDaño(enemigo.ObtenerDaño());
                    if (jugador.Vida <= 0)
                    {
                        Console.WriteLine("El jugador ha sido derrotado. Juego terminado.");
                        return;
                    }
                }

                turno++;
            }

            if (jugador.Vida > 0)
            {
                Console.WriteLine("\nTodos los enemigos han sido derrotados. ¡Victoria!");
            }
        }
    }
}
