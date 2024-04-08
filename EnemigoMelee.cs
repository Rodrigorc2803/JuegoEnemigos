using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_tarea
{
    internal class EnemigoMelee : Enemigo
    {
        public EnemigoMelee(int vida, int daño) : base(vida, daño) { }

        public override int ObtenerDaño()
        {
            return Daño;
        }
    }
}
