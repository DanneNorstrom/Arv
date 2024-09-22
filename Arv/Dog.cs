using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Dog : Animal
    {
        protected string Race = "";

        public Dog(string n, double w, int a, string r) : base(n, w, a)
        {
            Race = r;   
        }
        public override void DoSound()
        {
            Console.WriteLine("Voff!");
        }
        public override string Stats()
        {
            return name + " " + weight + " " + age.ToString() + " " + Race;
        }
        public string RetString()
        {
            return ("Valfri sträng");
        }
    }
}
