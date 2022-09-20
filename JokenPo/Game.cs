using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPo
{
    internal class Game
    {
        public enum Resultado
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Papel.png"),
            Image.FromFile("imagens/Tesoura.png")
        };

        public Image imgPC { get; private set; }

        public Image imgPlayer { get; private set; }

        public Resultado Jogar(int jogador)
        {
            int escolhaPC = JogadaPC();

            imgPlayer = images[jogador];
            imgPC = images[escolhaPC];

            if (jogador == escolhaPC)
            {
                return Resultado.Empatar;
            }
            else if ((jogador == 0 && escolhaPC == 2) || (jogador == 2 && escolhaPC == 1) || (jogador == 2 && escolhaPC == 1) || (jogador == 1 && escolhaPC == 0))
            {
                return Resultado.Ganhar;
            }else
            {
                return Resultado.Perder;
            }

        }

        private int JogadaPC()
        {
            int mSegundos = DateTime.Now.Millisecond;

            if (mSegundos < 333)
            {

                return 0;
            }
            else if (mSegundos >= 333 && mSegundos < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
