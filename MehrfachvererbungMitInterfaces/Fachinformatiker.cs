using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehrfachvererbungMitInterfaces {
    class Fachinformatiker:Eigenschaften, Kaufmann, Vogel {
        public void Fliegen () {
            Console.WriteLine ("Fiegt");
        }
        public void Programmieren () {
            Console.WriteLine ("Programmiert");
        }

        public void Verhandeln () {
            Console.WriteLine ("Verhandelt");
        }

        public void Verkaufen () {
            Console.WriteLine ("Verkauft");
        }
    }
}
