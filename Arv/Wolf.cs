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
        public Wolf(string n, double w, int a) : base(n, w, a)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Ylar!");
        }
    }
}
