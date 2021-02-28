using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrattegyPattern.Interfaces;

namespace StrattegyPattern
{
   public class Duck
    {
        IFlyBehavior fb;
        IQuackBehavior qb;

        public Duck(IFlyBehavior fb, IQuackBehavior qb) {
            this.fb = fb;
            this.qb = qb;
        }

        public void Fly() {
            this.fb.Fly();
        }

        public void Quack() {
            this.qb.Quack();
        }

    }
}
