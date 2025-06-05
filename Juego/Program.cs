using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    internal class Program
    {
        public static PocionVida PocionVida = new PocionVida(); public static PocionMana PocionMana = new PocionMana();
        public static void Carga(Personaje Personaje)
        {
            Inventario Inventario = new Inventario();
            Console.WriteLine("Ingrese el Color del personaje");
            Personaje.CambiarColor(Console.ReadLine());
            Console.WriteLine("Ingrese la Vida del personaje");
            Personaje.Vida = int.Parse(Console.ReadLine()); Personaje.VidaInicial = Personaje.Vida;
            Console.WriteLine("Ingrese la Defensa del personaje");
            Personaje.Defensa = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Fuerza del personaje");
            Personaje.Fuerza = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Mana del personaje");
            Personaje.Mana = int.Parse(Console.ReadLine()); Personaje.ManaInicial = Personaje.Mana;
            Personaje.Inventario = Inventario; Inventario.Personaje = Personaje;
            Personaje.Inventario.AgregarItem(PocionVida);
            Personaje.Inventario.AgregarItem(PocionMana);
            Personaje.Inventario.AgregarItem(new Casco());
            Personaje.Inventario.AgregarItem(new Chaleco());
            Personaje.Inventario.AgregarItem(new Espada());
        }
        public static void MostrarDatos(Personaje Personaje) 
        {
            Console.WriteLine("---Estadisticas---");
            Console.WriteLine($"Color: {Personaje.Color}");
            Console.WriteLine($"Vida: {Personaje.Vida}");
            Console.WriteLine($"Defensa: {Personaje.Defensa}");
            Console.WriteLine($"Fuerza: {Personaje.Fuerza}");
            Console.WriteLine($"Mana: {Personaje.Mana}");
            Console.WriteLine("---Inventario---");
            foreach (Item item in Personaje.Inventario.Items)
            {
                Console.WriteLine($"- {item}");
            }
        }
        static void Main(string[] args)
        {
            Personaje Personaje1 = new Personaje();
            Console.WriteLine("Personaje 1"); Carga(Personaje1); Console.Clear();
            Personaje Personaje2 = new Personaje();
            Console.WriteLine("Personaje 2"); Carga(Personaje2); 
            do
            {
                Console.Clear();
                Console.WriteLine("Personaje 1:"); MostrarDatos(Personaje1);
                Console.WriteLine("");
                Console.WriteLine("Personaje 2:"); MostrarDatos(Personaje2);
                Console.WriteLine("");
                Console.WriteLine("1- Cambiar de Color");
                Console.WriteLine("2- Recibir Daño");
                Console.WriteLine("3- Atacar");
                Console.WriteLine("4- Usar Item");
                Console.WriteLine("5- Equipar Item");
                Console.WriteLine("6- Desquipar Item");
                int Seleccion = int.Parse(Console.ReadLine()); Console.Clear();
                switch (Seleccion)
                {
                    case 1:
                        Console.WriteLine("A que color desea cambiar?");
                        Personaje1.CambiarColor(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Cuanto daño recibe?");
                        Console.WriteLine(Personaje1.RecibirDaño(int.Parse(Console.ReadLine())));
                        if (Personaje1.Vida <= 0)
                        {
                            Console.WriteLine("✝Te fuiste al cielo✝");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(Personaje1.Atacar(Personaje2));
                        if (Personaje2.Vida <= 0)
                        {
                            Console.WriteLine("Ganaste");
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        int i = 0; Console.WriteLine("---Inventario---");
                        foreach (Item item in Personaje1.Inventario.Items)
                        {
                            Console.WriteLine($"{i}- {item}"); i++;
                        }
                        Console.WriteLine(""); Console.WriteLine("Que item quiere usar?");
                        int ItemAUsar = int.Parse(Console.ReadLine());
                        if (Personaje1.Inventario.Items[ItemAUsar] is IUsable usable)
                        {
                            Console.WriteLine("Sobre quien quiere usar la pocion?");
                            Console.WriteLine("1- Jugador  2- Enemigo");
                            int Receptor = int.Parse(Console.ReadLine());
                            switch (Receptor)
                            {
                                case 1:
                                    usable.Usar(Personaje1);
                                    Personaje1.Inventario.QuitarItem(Personaje1.Inventario.Items[ItemAUsar]);
                                    break;
                                case 2:
                                    usable.Usar(Personaje2);
                                    Personaje1.Inventario.QuitarItem(Personaje1.Inventario.Items[ItemAUsar]);
                                    break;
                                default:
                                    Console.WriteLine("Elija una de las opciones");
                                    break;
                            }
                        }
                        else { Console.WriteLine("Este objeto no es Usable"); }
                        break;
                    case 5:
                        int e = 0; Console.WriteLine("---Inventario---");
                        foreach (Item item in Personaje1.Inventario.Items)
                        {
                            Console.WriteLine($"{e}- {item}"); e++;
                        }
                        Console.WriteLine(""); Console.WriteLine("Que item quiere equipar?");
                        int ItemAEquipar = int.Parse(Console.ReadLine());
                        if (Personaje1.Inventario.Items[ItemAEquipar] is IEquipable equipar)
                        {
                            equipar.Equipar(Personaje1);
                        }
                        else { Console.WriteLine("Este objeto no es Equipable"); }
                        break;
                    case 6:
                        int d = 0; Console.WriteLine("---Inventario---");
                        foreach (Item item in Personaje1.Inventario.Items)
                        {
                            Console.WriteLine($"{d}- {item}"); d++;
                        }
                        Console.WriteLine(""); Console.WriteLine("Que item quiere desequipar?");
                        int ItemADesquipar = int.Parse(Console.ReadLine());
                        if (Personaje1.Inventario.Items[ItemADesquipar] is IEquipable desequipar)
                        {
                            desequipar.Desequipar(Personaje1);
                        }
                        else { Console.WriteLine("Este objeto no está equipado"); }
                        break;
                    default:
                    Console.WriteLine("Elija una de las opciones");
                    break;
                }
            } while (Personaje1.Vida != 0);
        }
    }
}
