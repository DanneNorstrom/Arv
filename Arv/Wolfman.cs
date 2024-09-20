using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string n, double w, int a) : base(n, w, a)
        {
        }

        public void Talk()
        {
            Console.WriteLine("Grrrrrrrrrrrrrr!");
        }
    }
}
