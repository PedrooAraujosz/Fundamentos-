using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Mago : Personagem
    {
        public override void ApresentarSe()
        {
            Console.WriteLine(" Olá, eu sou o Mago " + this.Nome + " tenho " + this.Vida + " pontos de vida, inteligencia: " + this.Inteligencia + " Agilidade " + this.Agilidade + " \nForça " + this.Forca + "\nNível atual é: " + this.Nivel);

        }

        public virtual void atacar()
        {
            throw new NotImplementedException();
        }

        public virtual void batalha()
        {
            throw new NotImplementedException();
        }

        public virtual void Defender()
        {
            throw new NotImplementedException();
        }

        public virtual void Evoluir()
        {
            throw new NotImplementedException();
        }

        internal void apresentarSe()
        { }
    }
}
