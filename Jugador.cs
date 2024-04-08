using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_tarea
{
    internal class Jugador
    {
        public int Vida { get; private set; }
        public int Daño { get; private set; }

        public Jugador(int vida, int daño)
        {
            Vida = vida;
            Daño = daño;
        }

        public void RecibirDaño(int cantidad)
        {
            Vida -= cantidad;
            if (Vida < 0) Vida = 0;
        }

        public int ObtenerDaño()
        {
            return Daño;
        }
    }
}
