using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Worm : Animal
    {
        protected bool isPoisinous = false;

        public Worm(string n, double w, int a, bool ip) : base(n, w, a)
        {
            isPoisinous = ip;
        }

        public override void DoSound()
        {
            Console.WriteLine("Ljudet av en mask!");
        }
        public override string Stats()
        {
            return name + " " + weight + " " + age.ToString() +" " + isPoisinous.ToString();
        }
    }
}
