using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternDuckGameExample.Implementation;

namespace StrategyPatternDuckGameExample
{
    public class MallardDuck:Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I am MallardDuck");
        }
    }
}
