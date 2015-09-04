using StrategyPatternDuckGameExample.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDuckGameExample
{
    public class RubberDuck:Duck
    {
        public RubberDuck()
        {
            flyBehaviour = new CantFly();
            quackBehaviour = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I am rubber duck");
        }
    }
}
