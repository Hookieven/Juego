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
            
            if (Vida <= 0) 
            {
                Console.WriteLine("✝Te fuiste al cielo✝");
            }
            return DañoEfectivo;
        }
        public int Atacar(Personaje Personaje) 
        {
            if (Mana > 0)
            {
                Mana -= 1;
                Personaje.RecibirDaño(Fuerza);
                return Fuerza;
            }
            else 
            {
                Console.WriteLine("Sin maná");
                return 0;
            }
            
        }

    }
    internal class Program
    {
        public void Carga(Personaje Personaje)
        {
            Console.WriteLine("Ingrese el Color del personaje");
            Personaje.CambiarColor(Console.ReadLine());
            Console.WriteLine("Ingrese la Vida del personaje");
            Personaje.Vida = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Defensa del personaje");
            Personaje.Defensa = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Fuerza del personaje");
            Personaje.Fuerza = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Mana del personaje");
            Personaje.Mana = int.Parse(Console.ReadLine());
        }
        public void MostrarDatos(Personaje Personaje) 
        {
                Console.WriteLine("Color: " + Personaje.Color);
                Console.WriteLine("Vida: " + Personaje.Vida);
                Console.WriteLine("Defensa: " + Personaje.Defensa);
                Console.WriteLine("Fuerza: " + Personaje.Fuerza);
                Console.WriteLine("Mana: " + Personaje.Mana);
        }
        static void Main(string[] args)
        {
            Personaje Personaje1 = new Personaje();
            Carga(Personaje1);
            Personaje Personaje2 = new Personaje();
            Carga(Personaje2);
            Console.Clear();
            do
            {
                Console.WriteLine("Personaje 1:"); MostrarDatos(Personaje1);
                Console.WriteLine("Personaje 2:"); MostrarDatos(Personaje2);
                Console.WriteLine("1- Cambiar de Color");
                Console.WriteLine("2- Recibir Daño");
                Console.WriteLine("3- Atacar");
                int Seleccion = int.Parse(Console.ReadLine()); Console.Clear();
                switch (Seleccion)
                {
                    case 1:
                        Console.WriteLine("A que color desea cambiar?");
                        Personaje1.CambiarColor(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Cuanto daño recibe?");
                        Personaje1.RecibirDaño(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Personaje1.Atacar(Personaje2);
                        if (Personaje2.Vida <= 0)
                        {
                            Console.WriteLine("Ganaste");
                        }
                        break;
                    default:
                        Console.WriteLine("Elija una de las opciones");
                        break;
                }
            } while (Personaje1.Vida != 0);
        }
    }
}
