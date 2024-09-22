using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Swan : Bird
    {
        protected double LenghtOfNeck = 0;
        public Swan(string n, double w, int a, double ws, double lon) : base(n, w, a, ws)
        {
            LenghtOfNeck = lon;
        }
        public override void DoSound()
        {
            Console.WriteLine("Ljudet av en svan");
        }

        public override string Stats()
        {
            return name + " " + weight + " " + age.ToString() + " " + LenghtOfNeck.ToString();
        }
    }
}
