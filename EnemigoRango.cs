using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_tarea
{
    internal class EnemigoRango : Enemigo
    {
        public int Balas { get; private set; }

        public EnemigoRango(int vida, int daño, int balas) : base(vida, daño)
        {
            Balas = balas;
        }

        public override int ObtenerDaño()
        {
            if (Balas > 0)
            {
                Balas--;
                return Daño;
            }
            else
            {
                return 0; 
            }
        }
    }
}
