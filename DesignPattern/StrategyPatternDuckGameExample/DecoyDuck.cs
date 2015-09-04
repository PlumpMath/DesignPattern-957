using StrategyPatternDuckGameExample.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDuckGameExample
{
    public class DecoyDuck:Duck
    {
        public DecoyDuck()
        {
            flyBehaviour = new CantFly();
            quackBehaviour = new Mute();
        }
        public override void Display()
        {
            Console.WriteLine("I am mock duck");
        }
    }
}
