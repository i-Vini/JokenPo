﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
            lblPC.Visible = false;
            lblVoce.Visible = false; 
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(1);
            lblPC.Visible = false;
            lblVoce.Visible = false;
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(2);
            lblPC.Visible = false;
            lblVoce.Visible = false;    
        }

        private void StartGame(int opcao)
        {
            lblResultado.Visible = false;
            Game jogo = new Game();

            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Ganhar.png");
                    goto default;
                    break;
                case Game.Resultado.Perder:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Perder.png");
                    goto default;
                    break;
                case Game.Resultado.Empatar:
                    picResultado.BackgroundImage = Image.FromFile("imagens/Empatar.png");
                    goto default;
                    break;
                default:
                    picVoce.Image = jogo.imgPlayer;
                    picPC.Image = jogo.imgPC;
                    break;
            }

        }

       
    }
}
