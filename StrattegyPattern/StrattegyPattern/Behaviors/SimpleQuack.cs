using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrattegyPattern.Interfaces;

namespace StrattegyPattern.Behaviors
{
    public class SimpleQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("This is a simple quack behavior");
        }
    }
}
