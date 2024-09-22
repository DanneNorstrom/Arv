using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal abstract class Animal
    {
        protected string name;
        protected double weight;
        protected int age;

        //F: svar lägg till det framtida attributet som alla djur har här

        protected Animal(string n, double w, int a)
        {
            name = n;
            weight = w; 
            age = a;    
        }
        public abstract void DoSound();
        public abstract string Stats();
    }
}
