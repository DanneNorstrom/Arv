using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Horse : Animal
    {
        protected string Owner = "";
        public Horse(string n, double w, int a, string o) : base(n, w, a)
        {
            Owner = o;
        }

        public override void DoSound()
        {
            Console.WriteLine("Gnägg!");
        }

        public override string Stats()
        {
            return name + " " + weight + " " + age.ToString() + " " + Owner;
        }
    }
}
