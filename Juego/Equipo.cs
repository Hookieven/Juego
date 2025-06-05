using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public interface IEquipable 
    {
        void Equipar(Personaje Personaje);
        void Desequipar(Personaje Personaje);
    }
    public abstract class Equipo : Item, IEquipable
    {
        public bool Equipado;
        public abstract void Desequipar(Personaje Personaje);
        public abstract void Equipar(Personaje Personaje);
    }
}
