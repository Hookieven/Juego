using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    public class Inventario
    {
        public Personaje Personaje;
        public List<Item> Items = new List<Item>();

        public void AgregarItem(Item item)
        {
            Items.Add(item);
            item.Inventario = this;
        }
        public void QuitarItem(Item item)
        {
            Items.Remove(item);
            item.Inventario = null;
        }
    }
}
