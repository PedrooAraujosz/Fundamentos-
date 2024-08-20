using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public abstract class Personagem
    {
        //Atributos
        public string Nome { get; set; }

        public string Categoria { get; set; }

        public int Nivel { get; set; }

        public int Forca { get; set; }

        public int Agilidade { get; set; }

        public int Inteligencia { get; set; }

        public int Vida { get; set; }


        //Metodos

        public virtual void ApresentarSe() { }
        public virtual void Evoluir() { }
        public virtual int atacar()
        {
            int pontoAtaque = 0;
            pontoAtaque = (this.Inteligencia + this.Forca + this.Agilidade + this.Vida) / 5;
            return pontoAtaque;
        }
        public virtual int Defender()
        {
            int pontosDefesa = 0; pontosDefesa = (this.Inteligencia + this.Forca + (this.Agilidade * 2) + this.Nivel + this.Vida) / 6;
            return pontosDefesa;
        }
        public virtual void batalhar(Personagem p)
        {
            int valorAtaque = this.atacar();
            int valorDefesaInimigo = p.Defender();
            int danoDeVida = valorAtaque - valorDefesaInimigo;
            if (danoDeVida <= 0)
            {
                danoDeVida = 1;
            }
            p.Vida = p.Vida - danoDeVida;
            Console.WriteLine("Dano na Vida do Inimigo em " + danoDeVida);
            Console.WriteLine("O nível de vida do Inimigo agora é " + p.Vida);

            int valorAtaqueInimigo = p.atacar();
            int valorDefesa = this.Defender();
            int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
            if (danoDeVida2 <= 0)
            {
                danoDeVida2 = 1;
            }
            this.Vida = this.Vida - danoDeVida2;
            Console.WriteLine("Dano na Vida do Atacante em " + danoDeVida2);
            Console.WriteLine("O nível de vida do Atacante agora é " + this.Vida);
        }

    }
}