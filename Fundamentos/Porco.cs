using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public abstract class Porco : Animal
    {
        public override void emitirsom()
        {
            Console.WriteLine("ongi ongi");
        }
    }
}
