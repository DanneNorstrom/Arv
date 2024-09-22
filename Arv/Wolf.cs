using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Wolf : Animal
    {
        protected bool HasOffspring = false;
        public Wolf(string n, double w, int a, bool ho) : base(n, w, a)
        {
            HasOffspring = ho;
        }

        public override void DoSound()
        {
            Console.WriteLine("Ylar!");
        }

        public override string Stats()
        {
            return name + " " + weight + " " + age.ToString() + " " + HasOffspring.ToString();
        }
    }
}
