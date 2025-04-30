using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    internal abstract class Pocion
    {
        public int Minimo;
        public int Maximo;

        public abstract int Usar(Personaje Personaje);
    }
}
