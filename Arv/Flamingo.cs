using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Flamingo : Bird
    {
        protected double LegLenght = 0;
        public Flamingo(string n, double w, int a, double ws, double ll) : base(n, w, a, ws)
        {
            LegLenght = ll;
        }

        public override void DoSound()
        {
            Console.WriteLine("Ljudet av en flamingo");
        }

        public override string Stats()
        {
            return name + " " + weight + " " + age.ToString() + " " + LegLenght.ToString();
        }
    }
}
