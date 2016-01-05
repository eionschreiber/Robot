using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public abstract class Boss
    {
        public int HP = 100;
        public int Attack { get; set; }
        public int HeartPeice { get; set; }
        public string Name { get; set; }
        public bool Living { get; set; }
        public int MagicPower { get; set; }

        public bool Evil = true;
    }
}
