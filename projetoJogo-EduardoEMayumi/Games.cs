using System;
using System.Drawing;
using System.Windows.Forms;

namespace projetoJogo_EduardoEMayumi
{
    public partial class Games : Form
    {
        private Player jogador;

        public Games()
        {
            InitializeComponent();
            IniciarJogo();
        }

        private void IniciarJogo()
        {
            jogador = new Player();
            jogador.Location = new Point(50, 340); // largura, altura
            Controls.Add(jogador);

            KeyPreview = true;
            KeyDown += Games_KeyDown;
        }

        private void Games_KeyDown(object sender, KeyEventArgs e)
        {
            jogador.Mover(e.KeyCode, ClientSize.Width, ClientSize.Height);

            if (e.KeyCode == Keys.E)
            {
                Bullet disparo = jogador.Atirar();
                Controls.Add(disparo);
                disparo.BringToFront(); // garante que a maçã apareça na frente
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = jogador.Balas.Count - 1; i >= 0; i--)
            {
                Bullet disparo = jogador.Balas[i];
                disparo.Mover();

                if (disparo.SaiuDaTela())
                {
                    Controls.Remove(disparo);
                    jogador.Balas.RemoveAt(i);
                    disparo.Dispose();
                }
            }
        }
    }
}