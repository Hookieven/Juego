﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Chaleco : Equipo
    {
        public override void Equipar(Personaje Personaje)
        {
            if (Equipado == false)
            {
                Equipado = true;
            }
        }
        public override void Desequipar(Personaje Personaje)
        {
            if (Equipado == true)
            {
                Equipado = false;
            }
        }
        public override string ToString()
        {
            if (Equipado == true)
            {
                return "Chaleco (Equipado)";
            }
            else
            {
                return "Chaleco";
            }
        }
    }
}
