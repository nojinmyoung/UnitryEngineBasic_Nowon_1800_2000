using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance
{
    internal class Elephant : Creature, IFourLedggedWalker
    {
        public override void Breath()
        {
           
        }
        public void FourLedggedWalk()
        {
            Console.WriteLine("코끼리가 사족보행 한다");
        }
    }
}
