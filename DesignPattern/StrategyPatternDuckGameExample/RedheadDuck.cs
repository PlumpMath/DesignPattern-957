using StrategyPatternDuckGameExample.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDuckGameExample
{
    public class RedheadDuck:Duck
    {
        public RedheadDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new Squeek();
        }
        public override void Display()
        {
            Console.WriteLine(" I am redhead Duck");
        }
    }
}
