﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{   
    internal class Bird : Animal
    {
        protected double WingSpan = 0;

        //F: svar lägg till det framtida attributet som alla fåglar har här

        public Bird(string n, double w, int a, double wspan) : base(n, w, a)
        {
            WingSpan = wspan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Kvitter!");
        }

        public override string Stats()
        {
            return name +" " + weight +" " + age.ToString() +" " + WingSpan.ToString();
        }
    }
}
