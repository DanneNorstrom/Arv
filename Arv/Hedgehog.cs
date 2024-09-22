using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Hedgehog : Animal
    {
        protected int NrOfSpikes = 0;

        public Hedgehog(string n, double w, int a, int nr) : base(n, w, a)
        {
            NrOfSpikes = nr;
        }

        public override void DoSound()
        {
            Console.WriteLine("Ljudet av en igelkott!");
        }
        public override string Stats()
        {
            return name + " " + weight + " " + age.ToString() + " " + NrOfSpikes.ToString();
        }
    }
}
