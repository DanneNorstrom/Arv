using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Wolfman : Wolf, IPerson
    {
        protected double LengthOfClaws = 0;

        public Wolfman(string n, double w, int a, bool ho, double loc) : base(n, w, a, ho)
        {
            LengthOfClaws = loc;
        }
        public override string Stats()
        {
            return name + " " + weight + " " + age.ToString() + " " + LengthOfClaws.ToString();
        }

        public void Talk()
        {
            Console.WriteLine("Grrrrrrrrrrrrrr!");
        }
    }
}
