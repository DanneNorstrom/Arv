using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Pelican : Bird
    {
        protected double LenghtOfBeak = 0;
        public Pelican(string n, double w, int a) : base(n, w, a)
        {
        }
    }
}
