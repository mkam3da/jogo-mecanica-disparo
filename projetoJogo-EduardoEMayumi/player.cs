using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projetoJogo_EduardoEMayumi
{
    public class Player : PictureBox
    {
        public int Velocidade { get; set; } = 10;
        public List<Bullet> Balas { get; set; } = new List<Bullet>();

        public Player() // método construtor
        {
            Size = new Size(200, 200);
            SizeMode = PictureBoxSizeMode.StretchImage;
            BackColor = Color.Transparent;

            string caminhoimagem = Path.Combine(
                Application.StartupPath,
                "assets",
                "junimo-dance.gif"
            );
            Image = Image.FromFile(caminhoimagem);
        }

        public void Mover(Keys tecla, int larguraTela, int alturaTela)
        {
            if (tecla == Keys.W || tecla == Keys.Up)
            {
                Top -= Velocidade;
                if (Top + Height < 0)
                {
                    Top = alturaTela;
                }
            }
            else if (tecla == Keys.A || tecla == Keys.Left)
            {
                Left -= Velocidade;
                if (Left + Width < 0)
                {
                    Left = larguraTela;
                }
            }
            else if (tecla == Keys.S || tecla == Keys.Down)
            {
                Top += Velocidade;
                if (Top > alturaTela)
                {
                    Top = -Height;
                }
            }
            else if (tecla == Keys.D || tecla == Keys.Right)
            {
                Left += Velocidade;
                if (Left > larguraTela)
                {
                    Left = -Width;
                }
            }
        }

        public Bullet Atirar()
        {
            Bullet disparo = new Bullet(
                Left + (Width / 2),
                Top + (Height / 2)
            );

            Balas.Add(disparo);
            return disparo;
        }
    }
}