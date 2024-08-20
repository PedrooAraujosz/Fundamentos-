using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public abstract class Galinha : Animal
    {
        public override void emitirsom()
        {
            Console.WriteLine("pó pó pó");
        }
    }
}
