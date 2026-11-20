namespace projetoJogo_EduardoEMayumi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_tipo = new Label();
            btn_jogar = new Button();
            SuspendLayout();
            // 
            // lbl_tipo
            // 
            lbl_tipo.AutoSize = true;
            lbl_tipo.BackColor = Color.Transparent;
            lbl_tipo.Font = new Font("Cooper Black", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_tipo.ForeColor = Color.Goldenrod;
            lbl_tipo.Location = new Point(441, 203);
            lbl_tipo.Margin = new Padding(2, 0, 2, 0);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(434, 74);
            lbl_tipo.TabIndex = 0;
            lbl_tipo.Text = "Junimo Run";
            // 
            // btn_jogar
            // 
            btn_jogar.BackColor = Color.Goldenrod;
            btn_jogar.FlatStyle = FlatStyle.Flat;
            btn_jogar.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_jogar.ForeColor = Color.FromArgb(0, 0, 64);
            btn_jogar.Location = new Point(512, 279);
            btn_jogar.Margin = new Padding(2, 2, 2, 2);
            btn_jogar.Name = "btn_jogar";
            btn_jogar.Size = new Size(304, 57);
            btn_jogar.TabIndex = 1;
            btn_jogar.Text = "JOGAR";
            btn_jogar.UseVisualStyleBackColor = false;
            btn_jogar.Click += btn_jogar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1329, 614);
            Controls.Add(btn_jogar);
            Controls.Add(lbl_tipo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Jogo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_tipo;
        private Button btn_jogar;
    }
}
