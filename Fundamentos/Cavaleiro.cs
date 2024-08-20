using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Cavaleiro : Personagem
    {

        public virtual void apresentar()
        {

            Console.WriteLine(" Olá, eu sou um cavaleiro " + this.Nome + " tenho " + this.Vida + " pontos de vida, inteligencia: "
                + this.Inteligencia + " Agilidade " + this.Agilidade + " \nForça " + this.Forca + "\nNível atual é: " + this.Nivel);

        }
    }
}
