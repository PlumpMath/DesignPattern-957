using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternDuckGameExample.Interfaces;

namespace StrategyPatternDuckGameExample.Implementation
{
    public class FlyWithWings:IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am flying high");
        }
    }
}
