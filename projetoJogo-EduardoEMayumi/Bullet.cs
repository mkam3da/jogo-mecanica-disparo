using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace projetoJogo_EduardoEMayumi
{
    public class Bullet : PictureBox
    {
        public int Velocidade { get; set; } = 37;

        public Bullet(int x, int y)
        {
            BackColor = Color.Transparent;

            Left = x;
            Top = y;
            Size = new Size(37, 37);
            SizeMode = PictureBoxSizeMode.StretchImage;

            string caminhoImagem = Path.Combine(
                Application.StartupPath,
                "assets",
                "maca.png"
            );

            Image = Image.FromFile(caminhoImagem);
        }

        public void Mover()
        {
            Left += Velocidade;
        }

        public bool SaiuDaTela()
        {
            return Left + Width > 1920;
        }
    }
}
