using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpFeatures.Events
{
    public class Goblin
    {
        private int gold;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gold {
            get => gold;
            set
            {
                this.gold = value;
                this.OnGoldChanged?.Invoke(this, this.gold);
            }
        }
        // Event send data with the notifications
        public event EventHandler<int> OnGoldChanged;
    }
}
