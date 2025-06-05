using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Casco : Equipo
    {
        public override void Equipar(Personaje Personaje)
        {
            if (Equipado == false)
            {
                Console.WriteLine("Objeto equipado");
                Equipado = true;
            }
            else
            {
                Console.WriteLine("El Objeto ya está equipado");
            }
        }
        public override void Desequipar(Personaje Personaje)
        {
            if (Equipado == true)
            {
                Console.WriteLine("El Objeto fue desequipado");
                Equipado = false;
            }
            else
            {
                Console.WriteLine("El Objeto no está equipado");
            }
        }
        public override string ToString()
        {
            if (Equipado == true)
            {
                return "Casco (Equipado)";
            }
            else
            {
                return "Casco";
            }
        }
    }
}
