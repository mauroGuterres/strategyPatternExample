using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrattegyPattern.Behaviors;

namespace StrattegyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> duckList = new List<Duck>();

            duckList.Add(new Duck(new SimpleFly(), new SimpleQuack()));
            duckList.Add(new Duck(new NoFly(), new SimpleQuack()));
            duckList.Add(new Duck(new SimpleFly(), new NoQuack()));

            foreach (var duck in duckList) {
                duck.Fly();
                duck.Quack();
            }
            
            Console.ReadKey();
            
        }
    }
}
