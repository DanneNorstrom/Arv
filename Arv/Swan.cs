using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Swan : Bird
    {
        protected double LenghtOfNeck = 0;
        public Swan(string n, double w, int a) : base(n, w, a)
        {
        }
    }
}
