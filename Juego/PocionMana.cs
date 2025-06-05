using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class PocionMana : Pocion
    {
        Random Random = new Random();
        public override int Usar(Personaje Personaje)
        {
            if (Maximo > Personaje.ManaInicial) 
            {
                Maximo = Personaje.ManaInicial;
            }
            if (Minimo < 0) 
            {
                Minimo = 0;
            }
            Personaje.Mana += Random.Next(Minimo, Maximo);
            if (Personaje.Mana > Personaje.ManaInicial) 
            {
                Personaje.Mana = Personaje.ManaInicial;
            }
            return Personaje.Mana;
        }
        public override string ToString()
        {
            return "Pocion de Mana";
        }
    }
}
