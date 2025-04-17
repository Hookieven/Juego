using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Personaje
    {
        public string Color;
        public int Vida, Defensa, Fuerza, Mana;

        public void CambiarColor(string NuevoColor)
        {
            Color = NuevoColor;
        }
        public int RecibirDaño(int Daño)
        {
            int DañoEfectivo = (Daño - Defensa);
            if (DañoEfectivo < 0)
            {
                DañoEfectivo = 0;
            }
            Vida -= DañoEfectivo;
            return DañoEfectivo;
        }
        public int Atacar(Personaje Personaje)
        {
            if (Mana > 0)
            {
                Mana -= 1;
                return Personaje.RecibirDaño(Fuerza);
            }
            else
            {
                Console.WriteLine("Sin maná");
                return 0;
            }
        }
    }
}
