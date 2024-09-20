using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Dog : Animal
    {
        protected string Race;

        public Dog(string n, double w, int a) : base(n, w, a)
        {
        }
        public override void DoSound()
        {
            Console.WriteLine("Voff!");
        }
    }
}
