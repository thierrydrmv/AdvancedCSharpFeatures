using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpFeatures.Events
{
    internal class ExampleEvents
    {
        public ExampleEvents()
        {
            var goblin1 = new Goblin
            {
                Id = 1,
                Name = "Grob",
                Gold = 21
            };
            var goblin2 = new Goblin
            {
                Id = 2,
                Name = "Goblina",
                Gold = 3
            };

            goblin1.OnGoldChanged += GoblinOnFindGold;
            goblin1.OnGoldChanged += GoblinOnLostGold;
            goblin2.OnGoldChanged += GoblinOnFindGold;
            goblin2.OnGoldChanged += GoblinOnLostGold;

            goblin1.Gold += 12;
            goblin2.Gold += 7;
            for (int i = 0; i < 4; i++)
            {
                goblin1.Gold -= 10;
                goblin2.Gold += 4;
            }
        }
        private static void GoblinOnLostGold(object sender, int gold)
        {
            var goblin1 = (Goblin)sender;
            if (goblin1.Gold <= 0)
            {
                Console.WriteLine($"{goblin1.Name} has lost all his coins.");
                Console.WriteLine("-----------------------");
            }
        }
        private static void GoblinOnFindGold(object sender, int gold)
        {
            var goblin1 = (Goblin)sender;
            if (goblin1.Gold >= 0)
            {
                Console.WriteLine($"{goblin1.Name} has found gold: {gold}.");
                Console.WriteLine("-----------------------");
            }
        }
    }
}
