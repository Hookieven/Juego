using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    internal class PocionVida : Pocion
    {
        Random Random = new Random();
        public override int Usar(Personaje Personaje)
        {
            if (Maximo > Personaje.VidaInicial)
            {
                Maximo = Personaje.VidaInicial;
            }
            if (Minimo < 0)
            {
                Minimo = 0;
            }
            Personaje.Vida += Random.Next(Minimo, Maximo);
            if (Personaje.Vida > Personaje.VidaInicial)
            {
                Personaje.Vida = Personaje.VidaInicial;
            }
            return Personaje.Vida;
        }

        public override string ToString()
        {
            return "Pocion de Vida";
        }
    }
}
