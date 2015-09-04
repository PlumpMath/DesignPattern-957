using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternDuckGameExample.Interfaces;

namespace StrategyPatternDuckGameExample
{
    public abstract class Duck
    {
        public IFlyBehaviour flyBehaviour { get;set; }
        public IQuackBehaviour quackBehaviour { get;set; }

        public abstract void Display();

        public void Fly()
        {
            if (flyBehaviour != null)
            {
                flyBehaviour.Fly();
            }
            else
            {
                Console.WriteLine("No Implementation provided for IFlyBehaviour ");
            }
        }

        public void Quack()
        {
            if (quackBehaviour != null)
            {
                quackBehaviour.Quack();
            }
            else
            {
                Console.WriteLine("No Implementation provided for IQuackBehaviour ");
            }
        }

        public void Swim()
        {
            Console.WriteLine("Allducks can swim");
        }

    }
}
