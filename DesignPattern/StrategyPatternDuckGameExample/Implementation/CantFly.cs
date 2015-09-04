using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternDuckGameExample.Interfaces;

namespace StrategyPatternDuckGameExample.Implementation
{
    public class CantFly:IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }
}
