using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrattegyPattern.Interfaces;

namespace StrattegyPattern.Behaviors
{
    public class NoFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("This is a no fly behavior");
        }
    }
}
