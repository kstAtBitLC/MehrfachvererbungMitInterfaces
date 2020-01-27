using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehrfachvererbungMitInterfaces {
    class Tier : Vogel {
        public void Fliegen () {
            Console.WriteLine ("Fliegendes Tier - weil Vogel-Interface");
        }
    }
}
