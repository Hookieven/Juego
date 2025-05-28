using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    internal class Personaje
    {
        public string Color;
        public int VidaInicial, Vida, Defensa, Fuerza, ManaInicial, Mana;
        public Inventario Inventario;

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
