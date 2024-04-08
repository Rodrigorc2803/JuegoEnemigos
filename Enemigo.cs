using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_tarea
{
    internal abstract class Enemigo
    {
        public int Vida { get; protected set; }
        public int Daño { get; protected set; }

        protected Enemigo(int vida, int daño)
        {
            Vida = vida;
            Daño = daño;
        }

        public virtual void RecibirDaño(int cantidad)
        {
            Vida -= cantidad;
            if (Vida < 0) Vida = 0;
        }
        public abstract int ObtenerDaño();
        public bool EstaVivo()
        {
            return Vida > 0;
        }
    }
}

