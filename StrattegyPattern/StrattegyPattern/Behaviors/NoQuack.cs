using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrattegyPattern.Interfaces;

namespace StrattegyPattern.Behaviors
{
    public class NoQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("This is a no quack behavior");
        }
    }
}
