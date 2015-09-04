using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternDuckGameExample.Interfaces;

namespace StrategyPatternDuckGameExample.Implementation
{
    public class Mute:IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Cant Speek");
        }
    }
}
