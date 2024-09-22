using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Pelican : Bird
    {
        protected double LenghtOfBeak = 0;
        public Pelican(string n, double w, int a, double ws, double lob) : base(n, w, a, ws)
        {
            LenghtOfBeak = lob;
        }
        public override void DoSound()
        {
            Console.WriteLine("Ljudet av en pelikan");
        }

        public override string Stats()
        {
            return name + " " + weight + " " + age.ToString() + " " + LenghtOfBeak.ToString();
        }
    }
}
