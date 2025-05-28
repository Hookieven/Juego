using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    internal abstract class Item
    {
        public Inventario Inventario;
        public abstract int Usar(Personaje Personaje);
    }
}
