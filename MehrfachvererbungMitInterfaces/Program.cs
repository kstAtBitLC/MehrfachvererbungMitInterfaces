using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehrfachvererbungMitInterfaces {
    class Program {
        static void Main (string [] args) {
            Fachinformatiker fiae = new Fachinformatiker ();
            fiae.Fliegen ();
            fiae.Programmieren ();

            Vogel v = new Fachinformatiker ();
            Kaufmann kfm = new Fachinformatiker ();

            //Vogel Mein = new Vogel ();

            Vogel [] vogelArray = new Vogel[2];
            vogelArray [ 0 ] = v;
            vogelArray [ 1 ] = new Tier ();

            for ( int i = 0 ; i < vogelArray.Length ; i++ ) {
                vogelArray[i].Fliegen();
            }
            

            Console.ReadLine ();
        }
    }
}
