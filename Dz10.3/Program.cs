using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10._3
{
    interface ICreature
    {
        string CreatureType { get; }
    }

    class MagicBag<T> where T : ICreature
    {
        private HashSet<string> GiftsGiven = new HashSet<string>();

        public void Open(T creature)
        {
            if (GiftsGiven.Contains(creature.CreatureType))
            {
                Console.WriteLine("Sorry, a gift has already been given to a creature of type " + creature.CreatureType + " today.");
            }
            else
            {
                Console.WriteLine("A gift has appeared for a creature of type " + creature.CreatureType + "!");
                GiftsGiven.Add(creature.CreatureType);
            }
        }
    }

    class Elf : ICreature
    {
        public string CreatureType { get { return "Elf"; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MagicBag<ICreature> bag = new MagicBag<ICreature>();
            Elf elf = new Elf();

            bag.Open(elf);
            bag.Open(elf);
        }
    }
}
