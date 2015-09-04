using StrategyPatternDuckGameExample.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDuckGameExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck objDuck = new MallardDuck();
            objDuck.Fly();
            objDuck.Quack();
            
            Console.WriteLine("Change In Requirement");

            objDuck.flyBehaviour = new CantFly();
            objDuck.Fly();
            objDuck.Quack();
            Console.ReadLine();
        }
    }
}
